using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using RRHH.Entidades;

namespace RRHH
{
    class Login
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Usuario usuario;

        public Int32 ingresar(String NombreUsuario, String Password, String Secreta)
        {
            usuario = new Usuario();

            try
            {
                usuario = rrhh.Usuarios.FirstOrDefault(a => a.NombreUsuario == NombreUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (usuario != null)
            {
                if (usuario.NombreUsuario == NombreUsuario && Decrypt(usuario.Password) == Password)
                {
                    //entro con el password
                    MessageBox.Show("Usuario: " + NombreUsuario + " ACEPTADO");
                    MenuPrincipal menu = new MenuPrincipal(usuario);
                    menu.Visible = true;
                    return 1;
                    
                }
                else
                {
                    if (usuario.NombreUsuario == NombreUsuario && usuario.PalabraSecreta == Secreta)
                    {
                        //entro con la palabra secreta
                        MessageBox.Show("Usuario: " + NombreUsuario + " ACEPTADO");
                        MenuPrincipal menu = new MenuPrincipal(usuario);
                        menu.Visible = true;
                        return 1;
                    }
                    else
                    {
                        //no estan bien los datos
                        //MessageBox.Show("Revise los datos");
                        return 0;
                    }
                }
                
            }
            return 0;
        }


        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
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
