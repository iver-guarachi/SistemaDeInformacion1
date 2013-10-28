using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RRHH
{
    public partial class FormLogin : Form
    {
        private Login login = new Login();
  
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if(login.ingresar(textBoxNombre.Text, textBoxPassword.Text, textBoxSecreta.Text) == 1)
            {
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("error al entrar al programa");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



        
                
    }
}
