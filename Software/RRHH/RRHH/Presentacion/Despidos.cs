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
    public partial class Despidos : Form
    {
        public Despidos()
        {
            InitializeComponent();
        }

        private void Beneficios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSetFinalVsitas2.Empleados_NombreCompleto' Puede moverla o quitarla según sea necesario.
            this.empleados_NombreCompletoTableAdapter.Fill(this.recursosHumanosDataSetFinalVsitas2.Empleados_NombreCompleto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DespidoControl dsp = new DespidoControl();
            dsp.despedirEmpleado(Convert.ToInt32( listBox1.SelectedValue), textBox2.Text);
            this.empleados_NombreCompletoTableAdapter.Fill(this.recursosHumanosDataSetFinalVsitas2.Empleados_NombreCompleto);
            textBox1.Text = textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
        }
    }
}
