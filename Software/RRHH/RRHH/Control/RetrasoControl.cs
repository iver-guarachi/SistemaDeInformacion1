using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;

namespace RRHH.Control
{
    class RetrasoControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        public void insertarRetrasosFaltas(TimeSpan marca, TimeSpan registro, int idReg, int mes, int anio)
        {
            if (marca.Hours == registro.Hours)
            {
                if (marca.Minutes > registro.Minutes + 10 && marca.Minutes < registro.Minutes + 21)
                {
                    Retraso retraso = new Retraso();
                    retraso.id_Reg = idReg;
                    retraso.tiempoRetraso = marca.Minutes - registro.Minutes;
                    rrhh.Retrasoes.AddObject(retraso);
                    rrhh.SaveChanges();

                    var registros = from d in rrhh.RegistroHorarios
                                    where d.id_Empleado == 1 && d.Fecha.Value.Month == mes && d.Fecha.Value.Year== anio
                                    select d;
                    int cont = 0;
                    foreach (var rr in registros)
                    {
                        cont++;
                    }
                    if (cont % 3 == 0)
                    {
                        Falta falta = new Falta();
                        falta.id_Registro = idReg;
                        falta.idTipoFalta = 3;
                        falta.Motivo = "Acumulacion de retrasos";
                        rrhh.Faltas.AddObject(falta);
                        rrhh.SaveChanges();
                    }
                }
                if (marca.Minutes > registro.Minutes + 20 && marca.Minutes < registro.Minutes + 61)
                {
                    Falta falta = new Falta();
                    falta.id_Registro = idReg;
                    falta.idTipoFalta = 4;
                    falta.Motivo = "Retraso mayor a 20 minutos, es decir, medio dia de falta";
                    rrhh.Faltas.AddObject(falta);
                    rrhh.SaveChanges();
                }
            }
            else
            {
                if (marca.Hours > registro.Hours)
                {
                    Falta falta = new Falta();
                    falta.id_Registro = idReg;
                    falta.idTipoFalta = 5;
                    falta.Motivo = "Retraso mayor a 60 minutos igual a 1 falta";
                    rrhh.Faltas.AddObject(falta);
                    rrhh.SaveChanges();
                }
            }
        }

        public void insertarFaltasSinJustificacion(int idReg, DateTime fecha)
        {
            for (int i = 1; i <= 2; i++)
            {
                Falta falta = new Falta();
                falta.id_Registro = idReg;
                falta.idTipoFalta = 2;
                falta.Motivo = "Falta sin justificacion "+ i + " de la fecha: "+ fecha.Date.ToString();
                rrhh.Faltas.AddObject(falta);
                rrhh.SaveChanges();
            }
        }

        public void insertarFaltasJustificadas(int idReg, DateTime fecha, String motivo)
        {
            Falta falta = new Falta();
            falta.id_Registro = idReg;
            falta.idTipoFalta = 2;
            falta.Motivo = motivo;
            rrhh.Faltas.AddObject(falta);
            rrhh.SaveChanges();
        }
    }
}
