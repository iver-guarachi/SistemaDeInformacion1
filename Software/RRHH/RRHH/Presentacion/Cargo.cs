using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RRHH.Control;

namespace RRHH.Presentacion
{
    public partial class Cargo : Form
    {

        CargoControl cc = new CargoControl();
        private SolicitudPersonal solicitudPersonal;

        public Cargo()
        {
            InitializeComponent();            
        }

        public Cargo(SolicitudPersonal solicitudPersonal)
        {
            InitializeComponent();
            this.solicitudPersonal = solicitudPersonal;
        }

        private void buttonCrearRequisitos_Click(object sender, EventArgs e)
        {
            Requisito re = new Requisito(this);
            re.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxReq.Items.Clear();
            cargarReq();
        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet2.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter1.Fill(this.recursosHumanosDataSet2.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.Cargo' Puede moverla o quitarla según sea necesario.
            this.cargoTableAdapter.Fill(this.recursosHumanosDataSet1.Cargo);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.Requisitos' Puede moverla o quitarla según sea necesario.
            this.requisitosTableAdapter.Fill(this.recursosHumanosDataSet1.Requisitos);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.recursosHumanosDataSet1.Departamento);
            cargarReq();
            comboBoxDept.SelectedItem = 0;
        }
        private void cargarReq()
        {
            checkedListBoxReq.Items.Clear();
            List<RRHH.Entidades.Requisito> reqs = cc.cargarRequisitos();
            if(reqs!=null)
                for (int i = 0; i < reqs.Count; i++)
                {                   
                    checkedListBoxReq.Items.Add(reqs.ElementAt(i).Nombre);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> req = new List<String>();
            foreach (var item in checkedListBoxReq.CheckedItems)
            {
                req.Add(item.ToString());
            }
            if (Convert.ToInt32(textBoxMin.Text) < Convert.ToInt32(textBoxMax.Text))
                cc.insertarCargo(textBoxNombre.Text, textBoxMin.Text, textBoxMax.Text, comboBoxDept.Text, req);
            else
                MessageBox.Show("El salario Minimo debe ser menor que el Salario Maximo");
            ActualizarCampos();
        }



        public bool isCaracterValido(Char c)
        {
            if ((c >= '0' && c <= '9') || c=='\b')
            {
                return true;
            }
            return false;
        }

        private void textBoxMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isCaracterValido(e.KeyChar))
            {
                MessageBox.Show("El campo Salario Maximo es solo para valores numericos");
                e.Handled = true;
            }
        }

        private void textBoxMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isCaracterValido(e.KeyChar))
            {
                MessageBox.Show("El campo Salario Minimo es solo para valores numericos");
                e.Handled = true;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            List<String> req = new List<String>();
            foreach (var item in checkedListBoxReq.CheckedItems)
            {
                req.Add(item.ToString());
            }
            if (Convert.ToInt32(textBoxMin.Text) < Convert.ToInt32(textBoxMax.Text))
                cc.modificarCargo(textBoxNombre.Text, textBoxMin.Text, textBoxMax.Text, comboBoxDept.Text, req);
            else
                MessageBox.Show("El salario Minimo debe ser menor que el Salario Maximo");
            ActualizarCampos();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String ca = listBox1.GetItemText(listBox1.SelectedItem);
                RRHH.Entidades.Cargo c = new Entidades.Cargo();
                RRHH.Entidades.RecursosHumanosEntities rrhh = new RRHH.Entidades.RecursosHumanosEntities();
                c = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == ca);
                textBoxNombre.Text = c.Nombre;
                textBoxMin.Text = Convert.ToString(c.sueldoMinimo);
                textBoxMax.Text = Convert.ToString(c.sueldoMaximo);

                RRHH.Entidades.Departamento d = new Entidades.Departamento();
                d = rrhh.Departamentoes.FirstOrDefault(a => a.Id_Departamento == c.Id_Departamento);
                //int aux = comboBoxDept.Items.IndexOf(d.Nombre);
                comboBoxDept.SelectedItem = comboBoxDept.Items.IndexOf(d.Nombre);

                cargarReq();
                checkReq(textBoxNombre.Text);
            }
            catch
            {

            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("Realmente desea Eliminar " + textBoxNombre.Text +"?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)            
                 cc.eliminarCargo(textBoxNombre.Text);
            ActualizarCampos();
                      
        }

        private void checkReq(String nombre)
        {
            List<RRHH.Entidades.Requisito> reqs = cc.cargarReqModificar(nombre);
            if (reqs != null)
                for (int i = 0; i < reqs.Count; i++)
                {
                    int index = checkedListBoxReq.Items.IndexOf(reqs.ElementAt(i).Nombre);
                    checkedListBoxReq.SetItemChecked(index, true);
                }
        }

        private void ActualizarCampos()
        {
            textBoxNombre.Text = "";
            textBoxMax.Text = "";
            textBoxMin.Text = "";
            cargarReq();
            this.cargoTableAdapter.Fill(this.recursosHumanosDataSet1.Cargo);
        }




        public void obtenerRequisitos(List<Entidades.Requisito> req)
        {
            checkedListBoxReq.Items.Clear();
            for (int i = 0; i < req.Count; i++)
            {
                checkedListBoxReq.Items.Add(req.ElementAt(i).Nombre);
            }
        }

        private void Cargo_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                solicitudPersonal.refresh();
            }
            catch { }
        }

        
    }
}
