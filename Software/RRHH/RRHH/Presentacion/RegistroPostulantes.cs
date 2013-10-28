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

        public RegistroPostulantes()
        {
            InitializeComponent();
        }

        private void RegistroPostulantes_Load(object sender, EventArgs e)
        {  
        }

        private void cargarRequisito(String nombre)
        {  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargarRequisito(comboBox1.Text);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {  
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
      
    }
}
