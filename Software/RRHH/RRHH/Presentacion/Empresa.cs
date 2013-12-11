using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RRHH.Control;

namespace RRHH.Presentacion
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpresaControl emp = new EmpresaControl();

            try
            {
                if ((textBoxDireccion.Text == "") || (textBoxDireccion.Text == ""))
                {
                    MessageBox.Show("LLene los campos ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNombre.Focus();
                }
                else
                {
                    emp.guardarEmpresa(textBoxNombre.Text, textBoxDireccion.Text);
                    textBoxDireccion.Text = "";
                    textBoxNombre.Text = "";
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
    }
}
