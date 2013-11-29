using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;

namespace RRHH.Control
{
    class Horario
    {

        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Entidades.Horario h = new Entidades.Horario();

        public void modificar(String Nombre, TimeSpan horaEntrada, TimeSpan horaSalida)
        {
            h = rrhh.Horarios.FirstOrDefault(a => a.NombreTurno == Nombre);
            h.hraIngreso = horaEntrada;
            h.hraSalida = horaSalida;
            rrhh.SaveChanges();
        }

        

    }
}
