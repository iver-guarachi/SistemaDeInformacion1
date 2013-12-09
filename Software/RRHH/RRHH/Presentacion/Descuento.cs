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
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
        }
        ValidacionesControl valida = new ValidacionesControl();
        private void Descuento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistaFinal3.Empleados_NombreCompleto' Puede moverla o quitarla según sea necesario.
            this.empleados_NombreCompletoTableAdapter1.Fill(this.vistaFinal3.Empleados_NombreCompleto);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet_HastaDescuento.TipoDescuento' Puede moverla o quitarla según sea necesario.
            this.tipoDescuentoTableAdapter.Fill(this.recursosHumanosDataSet_HastaDescuento.TipoDescuento);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("tipo " + Convert.ToInt32(comboBox1.SelectedValue));
            Console.WriteLine("empleado " + Convert.ToInt32(comboBox2.SelectedValue));
            DescuentoControl des = new DescuentoControl();
            des.insertarDescuento(Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), textBoxMotivo.Text, Convert.ToDecimal(textBoxMonto.Text), dateTimePicker1.Value);
            comboBox2.SelectedIndex = comboBox1.SelectedIndex = -1;
            textBoxMotivo.Text = textBoxMonto.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!valida.SoloNumeros(e.KeyChar))
            {
                MessageBox.Show("Digite solo valores numericos");
                e.Handled = true;
            }
        }

       
    }
}
