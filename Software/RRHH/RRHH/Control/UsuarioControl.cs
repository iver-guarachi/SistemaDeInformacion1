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

        public void insertarUsuairo(String Nombre, String Password, String Confirmar, String Secreta, String rol)
        {
            usuario = new Usuario();
            usuario = rrhh.Usuarios.FirstOrDefault(a => a.NombreUsuario == usuario.NombreUsuario);
            if (usuario == null)
            {
                if ( Password == Confirmar && Password.Length > 7)
                {
                    Rol r = new Rol();
                    r = rrhh.Rols.FirstOrDefault(a => a.Nombre == rol);
                    usuario = new Usuario();
                    usuario.NombreUsuario = Nombre;
                  
                    usuario.Password = Password;
                    usuario.PalabraSecreta = Secreta;
                    usuario.IDRol = r.ID;
                    rrhh.Usuarios.AddObject(usuario);
                    rrhh.SaveChanges();
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
            
                if (usuario.Password == Password && Password == Confirmar && Password.Length > 7)
            {
                usuario.NombreUsuario = Nombre;
                usuario.Password = Password;
                usuario.PalabraSecreta = Secreta;
                usuario.IDRol = r.ID;
                rrhh.SaveChanges();
            }
            else
                MessageBox.Show("Datos erroneos. Verifique e intente nuevamente");
            
        }


       

        public void eliminarUsuairo(string nombre)
        {
            try
            {
                usuario = new Usuario();
                usuario = rrhh.Usuarios.FirstOrDefault(a => a.NombreUsuario == nombre);
                rrhh.Usuarios.DeleteObject(usuario);
                rrhh.SaveChanges();
            }
            catch { }
        }
    }
}
