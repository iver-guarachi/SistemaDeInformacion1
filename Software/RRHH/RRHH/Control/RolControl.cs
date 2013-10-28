using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;
using System.Windows.Forms;

namespace RRHH.Control
{
    class RolControl
    {

        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Rol rol;

        public void insertarRol(string Nombre)
        {
            rol = new Rol();
            rol.Nombre = Nombre;
            rrhh.Rols.AddObject(rol);
            rrhh.SaveChanges();
            MessageBox.Show("Se ha guardado exitosamente el Rol " + Nombre);
        }

        public void modificarRol(String NombreNuevo, String Nombre)
        {
            rol = new Rol();
            rol = rrhh.Rols.FirstOrDefault(a => a.Nombre == Nombre); //busqueda
            rol.Nombre = NombreNuevo;
            rrhh.SaveChanges();
            MessageBox.Show("Se ha modificado exitosamente el Rol " + Nombre + "con el nombre: " + NombreNuevo);
        }

        public void eliminarRol(String nombre)
        {
            rol = new Rol();
            rrhh.Rols.DeleteObject(rrhh.Rols.FirstOrDefault(a => a.Nombre == nombre));
            rrhh.SaveChanges();
        }

    }
}
