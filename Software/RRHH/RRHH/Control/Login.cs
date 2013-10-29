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
                if (usuario.NombreUsuario == NombreUsuario && usuario.Password == Password)
                {
                    //entro con el password
                    //MessageBox.Show("exito con password");
                    MenuPrincipal menu = new MenuPrincipal(usuario);
                    menu.Visible = true;
                    return 1;
                    
                }
                else
                {
                    if (usuario.NombreUsuario == NombreUsuario && usuario.PalabraSecreta == Secreta)
                    {
                        //entro con la palabra secreta
                        MenuPrincipal menu = new MenuPrincipal(usuario);
                        menu.Visible = true;
                        return 1;
                    }
                    else
                    {
                        //no estan bien los datos
                        //MessageBox.Show("revisar los datos");
                        return 0;
                    }
                }
                
            }
            return 0;
        }


   
    }
}
