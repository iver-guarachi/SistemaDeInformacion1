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
    public partial class RegistroPostulantes : Form
    {
        ValidacionesControl valida = new ValidacionesControl(); 
        RegistroPostulantesControl spc = new RegistroPostulantesControl();
        public RegistroPostulantes()
        {
            InitializeComponent();
        }

        private void RegistroPostulantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet2.SolicitudPersonal' Puede moverla o quitarla según sea necesario.
            this.solicitudPersonalTableAdapter.Fill(this.recursosHumanosDataSet2.SolicitudPersonal);

        }

        private void cargarRequisito(String nombre)
        {
            checkedListBoxRequisitos.Items.Clear();
           List<String> reqs = spc.cargarRequisito(nombre);
           if (reqs != null)
               for (int i = 0; i < reqs.Count; i++)
               {
                   checkedListBoxRequisitos.Items.Add(reqs.ElementAt(i));
               }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarRequisito(comboBox1.Text);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String gener = "A";
            if(!radioButtonFem.Checked && radioButtonMas.Checked)
                gener ="F";
            if(radioButtonFem.Checked && !radioButtonMas.Checked)
                gener = "M";

            List<String> req = new List<String>();
            foreach (var item in checkedListBoxRequisitos.CheckedItems)
            {
                req.Add(item.ToString());
            }

            spc.insertarPostulante(comboBox1.Text, textBoxNombre.Text, textBoxApellido.Text, textBoxTelefono.Text, textBoxMail.Text,
               textBoxCI.Text, comboBoxNacionalidad.Text, gener, dateTimePickerNaciomiento.Value, Convert.ToInt32(numericUpDownEdad.Value),
               textBoxAcademico.Text, textBoxReferencias.Text, req);
            textBoxNombre.Text = textBoxApellido.Text = textBoxTelefono.Text = textBoxMail.Text = textBoxCI.Text = comboBoxNacionalidad.Text = textBoxReferencias.Text = textBoxAcademico.Text = "";
            numericUpDownEdad.Value = 0;
            radioButtonFem.Checked = radioButtonMas.Checked = false;
            checkedListBoxRequisitos.Items.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePickerNaciomiento_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownEdad.Value = Convert.ToDecimal(Edad(dateTimePickerNaciomiento.Value));
        }

        public int Edad(DateTime fechaNacimiento)
        {
            //Obtengo la diferencia en años.
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            //Obtengo la fecha de cumpleaños de este año.
            DateTime nacimientoAhora = fechaNacimiento.AddYears(edad);
            //Le resto un año si la fecha actual es anterior 
            //al día de nacimiento.
            if (DateTime.Now.CompareTo(nacimientoAhora) < 0)
            { 
                edad--; 
            }
            return edad;
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!valida.SoloLetras(e.KeyChar))
            {
                MessageBox.Show("Digite solo Letras");
                e.Handled = true;
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!valida.SoloLetras(e.KeyChar))
            {
                MessageBox.Show("Digite solo Letras");
                e.Handled = true;
            }
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!valida.SoloNumeros(e.KeyChar))
            {
                MessageBox.Show("Digite solo valores numericos");
                e.Handled = true;
            }
        }

        private void textBoxCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!valida.SoloNumeros(e.KeyChar))
            {
                MessageBox.Show("Digite solo valores numericos");
                e.Handled = true;
            }
        }
    }
}
