using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
namespace RRHH
{
    class UsuarioControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Usuario usuario;

        public void insertarUsuairo(String Nombre, String Password, String Confirmar, String Secreta, String rol, int empleado)
        {
            usuario = new Usuario();
            usuario = rrhh.Usuarios.FirstOrDefault(a => a.NombreUsuario == usuario.NombreUsuario);
            if (usuario == null)
            {
                if (Password == Confirmar && Password.Length > 7)
                {
                    Rol r = new Rol();
                    r = rrhh.Rols.FirstOrDefault(a => a.Nombre == rol);
                    usuario = new Usuario();
                    usuario.NombreUsuario = Nombre;
                    usuario.Password = Encrypt(Password);
                    usuario.PalabraSecreta = Secreta;
                    usuario.IDRol = r.ID;
                    usuario.ID_Empleado = empleado;
                    rrhh.Usuarios.AddObject(usuario);
                    rrhh.SaveChanges();
                    MessageBox.Show("Se guardo el usuario: " + Nombre);
                }
                else
                {
                    MessageBox.Show("La contraseña debe tener mas de 7 digitos");
                }
            }
            else
                MessageBox.Show("No se puede guardar el usuario, ya existe uno con ese nombre. Verifique e intente nuevamente");            
        }

        public void modificarUsuario(String Nombre, String Password, String Confirmar, String Secreta, String rol)
        {
            Rol r = new Rol();
            r = rrhh.Rols.FirstOrDefault(a => a.Nombre == rol);
            usuario = new Usuario();
            usuario = rrhh.Usuarios.FirstOrDefault(a => a.NombreUsuario == usuario.NombreUsuario);
            if (Decrypt(usuario.Password) == Password && Password == Confirmar && Password.Length > 7)
            {
                usuario.NombreUsuario = Nombre;
                usuario.Password = Password;
                usuario.PalabraSecreta = Secreta;
                usuario.IDRol = r.ID;
                rrhh.SaveChanges();
                MessageBox.Show("Se Modifico el usuario: " + Nombre);
            }
            else
                MessageBox.Show("Datos erroneos. Verifique e intente nuevamente");
            
        }


        //metodos de encriptacion para la contraseña DES
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

        public void eliminarUsuairo(string nombre)
        {            
            rrhh.Usuarios.DeleteObject(rrhh.Usuarios.FirstOrDefault(a => a.NombreUsuario == nombre));
            rrhh.SaveChanges();
            MessageBox.Show("Se Elimino el usuario: " + nombre);
        }
    }
}
