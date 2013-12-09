using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;

namespace RRHH.Control
{
    class OtorgarVacacionControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        OtorgarVacacion ova;
        public void insertarOtorgarVacacion(int idEmpleado, DateTime inicio, DateTime fin)
        {
            ova = new OtorgarVacacion();
            ova.idEmpleado = idEmpleado;
            ova.FechaInicio = inicio;
            ova.FechaFin = fin;
            rrhh.OtorgarVacacions.AddObject(ova);
            rrhh.SaveChanges();
        }
    }
}
