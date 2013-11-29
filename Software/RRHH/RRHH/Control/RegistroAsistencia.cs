using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;

namespace RRHH.Control
{
    class RegistroAsistencia
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        RetrasoControl retrasoFalta = new RetrasoControl();
        public void insertarRegistroHorario(int empleado, int horario, int tipo, DateTime fecha, TimeSpan hora)
        {
            RegistroHorario rho = new RegistroHorario();
            rho.id_Empleado = empleado;
            rho.id_Horario = horario;
            rho.Id_Tipo = tipo;
            rho.Fecha = fecha;
            rho.hora = hora;

            rrhh.RegistroHorarios.AddObject(rho);
            rrhh.SaveChanges();

            var regis = from r in rrhh.RegistroHorarios
                        select r.id_Reg;
            int idReg = 0;
            foreach (var rr in regis)
            {
                idReg = rr;
            }
            var horarios = from h in rrhh.Horarios
                           where h.id_Horario == horario
                           select h.hraIngreso;
            TimeSpan hraing = new TimeSpan();
            foreach (var hh in horarios)
            {
                hraing = hh;
            }

            retrasoFalta.insertarRetrasosFaltas(hora, hraing, idReg, fecha.Month, fecha.Year);
        }

        public void insertarRegistroFaltaJustificada(int empleado, int horario, int tipo, DateTime fecha, TimeSpan hora, String motivo)
        {
            RegistroHorario rho = new RegistroHorario();
            rho.id_Empleado = empleado;
            rho.id_Horario = horario;
            rho.Id_Tipo = tipo;
            rho.Fecha = fecha;
            rho.hora = hora;

            rrhh.RegistroHorarios.AddObject(rho);
            rrhh.SaveChanges();
            var regis = from r in rrhh.RegistroHorarios
                        select r.id_Reg;
            int idReg = 0;
            foreach (var rr in regis)
            {
                idReg = rr;
            }
            retrasoFalta.insertarFaltasJustificadas(idReg, fecha, motivo);
        }

        public void insertarRegistroFaltaSinJustificada(int empleado, int horario, int tipo, DateTime fecha, TimeSpan hora)
        {
            RegistroHorario rho = new RegistroHorario();
            rho.id_Empleado = empleado;
            rho.id_Horario = horario;
            rho.Id_Tipo = tipo;
            rho.Fecha = fecha;
            rho.hora = hora;

            rrhh.RegistroHorarios.AddObject(rho);
            rrhh.SaveChanges();
            var regis = from r in rrhh.RegistroHorarios
                        select r.id_Reg;
            int idReg = 0;
            foreach (var rr in regis)
            {
                idReg = rr;
            }
            retrasoFalta.insertarFaltasSinJustificacion(idReg, fecha);
        }

        
    }
}
