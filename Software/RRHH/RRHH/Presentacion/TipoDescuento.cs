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
    public partial class TipoDescuento : Form
    {
        TipoDescuentoControl tpoDesc = new TipoDescuentoControl();
        public TipoDescuento()
        {
            InitializeComponent();
        }

        private void TipoDescuento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet_HastaDescuento.TipoDescuento' Puede moverla o quitarla según sea necesario.
            this.tipoDescuentoTableAdapter.Fill(this.recursosHumanosDataSet_HastaDescuento.TipoDescuento);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tpoDesc.insertarTipoDescuento(textBox1.Text);
            this.tipoDescuentoTableAdapter.Fill(this.recursosHumanosDataSet_HastaDescuento.TipoDescuento);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tpoDesc.modificarTipoDescuento(listBox1.Text, textBox1.Text);
            this.tipoDescuentoTableAdapter.Fill(this.recursosHumanosDataSet_HastaDescuento.TipoDescuento);
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tpoDesc.eliminarTipoDescuento(listBox1.Text);
            this.tipoDescuentoTableAdapter.Fill(this.recursosHumanosDataSet_HastaDescuento.TipoDescuento);
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
