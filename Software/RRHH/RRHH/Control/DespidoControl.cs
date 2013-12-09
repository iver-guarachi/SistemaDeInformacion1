using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;

namespace RRHH.Control
{
    class DespidoControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        public void despedirEmpleado(int idEmpleado, String motivo) 
        {
            Despido despido = new Despido();
            despido.idEmpleado = idEmpleado;
            despido.Motivo = motivo;
            rrhh.Despidoes.AddObject(despido);
            rrhh.SaveChanges();

            Empleado emp = rrhh.Empleadoes.FirstOrDefault( a => a.Id_Empleado ==  idEmpleado);
            emp.activo = 0;
            rrhh.SaveChanges();
        }
    }
}
