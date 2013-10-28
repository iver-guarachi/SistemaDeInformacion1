using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;

namespace RRHH.Control
{
    class RequisitosControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Requisito req = new Requisito();


        public void insertarRequisito(String Nombre, String Descripcion)
        {
            req.Nombre = Nombre;
            req.Descripcion = Descripcion;

            rrhh.Requisitos.AddObject(req);
            rrhh.SaveChanges();
        }

        public void modificarRequisitos(String Nombre, String nNombre, String Descripcion)
        {
            req = rrhh.Requisitos.FirstOrDefault(a => a.Nombre == Nombre);
            req.Nombre = nNombre;
            req.Descripcion = Descripcion;

            rrhh.SaveChanges();
        }

        public void eliminarRequisito(String nombre)
        {
            rrhh.Requisitos.DeleteObject(rrhh.Requisitos.FirstOrDefault(a => a.Nombre == nombre));
            rrhh.SaveChanges();
        }
    }
}
