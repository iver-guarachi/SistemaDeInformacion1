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
        public Departamento()
        {
            InitializeComponent();
        }

        private void Departamento_Load(object sender, EventArgs e)
        {
          
            this.departamentoTableAdapter.Fill(this.recursosHumanosDataSet1.Departamento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dep.insertarDepartamento(textBox2.Text);
            cargarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            dep.modificarDepartamento(listBox1.GetItemText(listBox1.SelectedItem), textBox2.Text);
            cargarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dep.eliminar(listBox1.GetItemText(listBox1.SelectedItem));
            cargarLista();
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarLista()
        {
            this.departamentoTableAdapter.Fill(this.recursosHumanosDataSet1.Departamento);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }
    }
}
