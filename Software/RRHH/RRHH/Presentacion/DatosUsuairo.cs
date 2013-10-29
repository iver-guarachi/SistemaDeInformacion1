using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using RRHH.Entidades;

namespace RRHH
{
    public partial class DatosUsuairo : Form
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Usuario usuarios = new Usuario();
        public DatosUsuairo(Usuario usuario)
        {
            InitializeComponent();
            textBoxNombre.Text = usuario.NombreUsuario;          
            textBoxSecreta.Text = usuario.PalabraSecreta;
            usuarios = usuario;
        }

        private void DatosUsuairo_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuarioComparar = new Usuario();
            usuarioComparar = rrhh.Usuarios.FirstOrDefault(a => a.NombreUsuario == usuarios.NombreUsuario);
            usuarioComparar.NombreUsuario = textBoxNombre.Text;
            if (textBoxAnteriorPassword.Text == usuarioComparar.Password && textBoxNuevoPassword.Text == textBoxConfirmarPassword.Text && textBoxConfirmarPassword.Text.Length > 7)
            {
                usuarioComparar.Password = textBoxConfirmarPassword.Text;                
                MessageBox.Show("Se a modificado los datos del usuario exitosamente");
            }
            else 
            {
                if (textBoxConfirmarPassword.Text.Length < 8)
                    MessageBox.Show("la contrasenia debe tener minimo 8 caracteres");
                else
                    MessageBox.Show("la contrasenia esta equivocada");
                return;
            }
            if(textBoxSecreta.Text != null)
                usuarioComparar.PalabraSecreta = textBoxSecreta.Text;

            rrhh.SaveChanges();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


       
       
    }
}
