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
    public partial class Memrandum : Form
    {
        public Memrandum()
        {
            InitializeComponent();
        }

        private void Memrandum_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSetVistasFinal.Empleados_NombreCompleto' Puede moverla o quitarla según sea necesario.
            this.empleados_NombreCompletoTableAdapter1.Fill(this.recursosHumanosDataSetVistasFinal.Empleados_NombreCompleto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.MemorandumControl memo = new Control.MemorandumControl();
            memo.insertarMemorandum(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value, textBox3.Text);
            textBox3.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
