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
    public partial class Departamento : Form
    {
        DepartamentoControl dep = new DepartamentoControl();
        ValidacionesControl valida = new ValidacionesControl();
        public Departamento()
        {
            InitializeComponent();
        }

        private void Departamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.recursosHumanosDataSet1.Departamento);

        }

        private void cargarLista()
        {
            this.departamentoTableAdapter.Fill(this.recursosHumanosDataSet1.Departamento);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNombre.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNombre.MaxLength = 20;

            if (!valida.SoloLetras(e.KeyChar))
            {
                MessageBox.Show("Digite solo Letras");
                e.Handled = true;
            }
        }
        
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text == "")
                {
                    MessageBox.Show("Ingrese un Nombre de Departamento ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Focus();
                }
                else
                {
                    dep.insertarDepartamento(textBoxNombre.Text);
                    textBoxNombre.Text = "";
                    cargarLista();
                }

            }
            catch
            {

            }

          
           
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text == "")
                {
                    MessageBox.Show("Seleccione un Departamento ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Focus();
                }
                else
                {
                    dep.modificarDepartamento(listBox1.GetItemText(listBox1.SelectedItem), textBoxNombre.Text);
                    textBoxNombre.Text = "";
                    cargarLista();
                }
            }
            catch
            {

            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxNombre.Text=="")
                {
                    MessageBox.Show("Seleccione un Departamento  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Focus();
                }
                else
                {
                 dep.eliminar(listBox1.GetItemText(listBox1.SelectedItem));
                 cargarLista();
                 textBoxNombre.Text = "";
                }
            }
            catch{
            }
            
        }
    }
}
