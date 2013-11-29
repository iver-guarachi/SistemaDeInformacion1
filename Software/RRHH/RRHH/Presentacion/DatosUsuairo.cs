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
            if (textBoxAnteriorPassword.Text == Decrypt(usuarioComparar.Password) && textBoxNuevoPassword.Text == textBoxConfirmarPassword.Text && textBoxConfirmarPassword.Text.Length > 7)
            {
                usuarioComparar.Password = Encrypt(textBoxConfirmarPassword.Text);                
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


        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
        public static string Encrypt(string originalString)
        {
            if (String.IsNullOrEmpty(originalString))
            {
                throw new ArgumentNullException
                       ("The string which needs to be encrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        public static string Decrypt(string cryptedString)
        {
            if (String.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException
                   ("The string which needs to be decrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream
                    (Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }
    }
}
