using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;
using System.Windows.Forms;

namespace RRHH.Control
{
    class DepartamentoControl
    {

        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Departamento dep = new Departamento();

        public void insertarDepartamento(String nombre)
        {
            try
            {
                dep.Nombre = nombre;
                rrhh.Departamentoes.AddObject(dep);
                rrhh.SaveChanges();
                MessageBox.Show("se ha Agregado el departamento " + nombre);
             
            }
            catch { }
        }

        public void modificarDepartamento(String Nombre, String nNombre)
        {
            dep = rrhh.Departamentoes.FirstOrDefault(a => a.Nombre == Nombre);
            dep.Nombre = nNombre;
            rrhh.SaveChanges();
            MessageBox.Show("Se ha modificado exitosamente el Departamento " + Nombre + " con el nombre: " + nNombre);
        }

        public void eliminar(String Nombre)
        {
            rrhh.Departamentoes.DeleteObject(rrhh.Departamentoes.FirstOrDefault(a => a.Nombre == Nombre));
            rrhh.SaveChanges();
            MessageBox.Show("Se a Eliminado exitosamente "+ Nombre);
        }
    }
}
