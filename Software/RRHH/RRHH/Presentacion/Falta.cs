using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RRHH.Presentacion
{
    public partial class Falta : Form
    {
        Control.RegistroAsistencia asistencia = new Control.RegistroAsistencia();
        Control.RetrasoControl retraso = new Control.RetrasoControl();
        public Falta()
        {
            InitializeComponent();
        }

        private void Falta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSetVistas2.Empleados_NombreCompleto' Puede moverla o quitarla según sea necesario.
            this.empleados_NombreCompletoTableAdapter.Fill(this.recursosHumanosDataSetVistas2.Empleados_NombreCompleto);
            textBox1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                TimeSpan hora = new TimeSpan();
                asistencia.insertarRegistroFaltaJustificada(Convert.ToInt32(comboBox1.SelectedValue), 3, 3, dateTimePickerFechaReg.Value, hora , textBox1.Text); 
            }
            if (radioButton2.Checked)
            {
                TimeSpan hora = new TimeSpan();
                asistencia.insertarRegistroFaltaSinJustificada(Convert.ToInt32(comboBox1.SelectedValue), 3, 3, dateTimePickerFechaReg.Value, hora);
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
