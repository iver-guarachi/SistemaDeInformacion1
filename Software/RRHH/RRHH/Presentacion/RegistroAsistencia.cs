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
    public partial class RegistroAsistencia : Form
    {
        public RegistroAsistencia()
        {
            InitializeComponent();
        }

        private void RegistroAsistencia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSetVistasFinal.Empleados_NombreCompleto' Puede moverla o quitarla según sea necesario.
            this.empleados_NombreCompletoTableAdapter.Fill(this.recursosHumanosDataSetVistasFinal.Empleados_NombreCompleto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo =-1;
            int turno = -1;
            if (checkBoxEntrada.Checked)
                tipo = 1;
            if (checkBoxSalida.Checked)
                tipo = 2;
            if (checkBoxManana.Checked)
                turno = 1;
            if (checkBoxTarde.Checked)
                turno = 2;
            String hora = numericUpDownHora.Value + ":" + numericUpDownMin.Value;
            Control.RegistroAsistencia ras = new Control.RegistroAsistencia();
            ras.insertarRegistroHorario(Convert.ToInt32(comboBox1.SelectedValue), tipo, turno, dateTimePickerFechaReg.Value, 
                TimeSpan.Parse(hora));
            numericUpDownHora.Value = numericUpDownMin.Value = 0;
            checkBoxEntrada.Checked = checkBoxSalida.Checked = checkBoxManana.Checked = checkBoxTarde.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxTarde_Click(object sender, EventArgs e)
        {
            checkBoxTarde.Checked = true;
            checkBoxManana.Checked = false;
        }

        private void checkBoxManana_Click(object sender, EventArgs e)
        {
            checkBoxTarde.Checked = false;
            checkBoxManana.Checked = true;
        }

        private void checkBoxEntrada_Click(object sender, EventArgs e)
        {
            checkBoxSalida.Checked = false;
            checkBoxEntrada.Checked = true;
        }

        private void checkBoxSalida_Click(object sender, EventArgs e)
        {
            checkBoxEntrada.Checked = false;
            checkBoxSalida.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Falta falta = new Falta();
            falta.Show();
        }

      
    }
}
