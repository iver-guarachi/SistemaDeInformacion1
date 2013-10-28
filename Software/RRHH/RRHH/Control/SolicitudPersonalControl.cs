using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;

namespace RRHH.Control
{
    class SolicitudPersonalControl
    {

        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        SolicitudPersonal personal = new SolicitudPersonal();
        

        public void insertarSolicitdPersonal(String Nombre, int vacantes, DateTime fechaCreacion, DateTime fechaExpiracion, String Cargo)
        {
            Cargo c = new Cargo();
            c = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == Cargo);
            personal.NombreSolicitud = Nombre;
            personal.NroVacantes = vacantes;
            personal.Fecha_creacion = fechaCreacion;
            personal.Fecha_Expiracion = fechaExpiracion;
            personal.Id_Cargo = c.Id_Cargo;

            rrhh.SolicitudPersonals.AddObject(personal);
            rrhh.SaveChanges();
        }

        public void modificarSolicitud(String vNombre, String Nombre, int vacantes, DateTime fechaCreacion, DateTime fechaExpiracion, String Cargo)
        {
            Cargo c = new Cargo();
            c = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == Cargo);
            
            personal = rrhh.SolicitudPersonals.FirstOrDefault(a => a.NombreSolicitud == vNombre);
            personal.NombreSolicitud = Nombre;
            personal.NroVacantes = vacantes;
            personal.Fecha_creacion = fechaCreacion;
            personal.Fecha_Expiracion = fechaExpiracion;
            personal.Id_Cargo = c.Id_Cargo;
            
            rrhh.SaveChanges();
        }

        public void eliminarSolicitud(int id)
        {
            rrhh.SolicitudPersonals.DeleteObject(rrhh.SolicitudPersonals.FirstOrDefault(a => a.Id_Solicitud == id));
        }

        internal List<String> cargarRequisitos(String cargo)
        {
            try
            {
                Cargo c = new Cargo();
                c = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == cargo);
                var req = from r in rrhh.Req_Cargo
                          where r.Id_Cargo == c.Id_Cargo
                          select r;
                List<Req_Cargo> requisito = new List<Req_Cargo>();
                foreach (var rr in req)
                {
                    requisito.Add(rr);
                }
                requisito = eliminarRepetidos(requisito);
                List<String> nombreReq = new List<string>();
                for (int i = 0; i < requisito.Count; i++)
                {
                    Requisito nr = new Requisito();
                    int id = (int)requisito.ElementAt(i).Id_Req;
                    nr = rrhh.Requisitos.FirstOrDefault(a => a.Id_Requisito == id);
                    nombreReq.Add(nr.Nombre);
                }
                return nombreReq;
            }
            catch
            {
                return null;
            }
        }

        private List<Req_Cargo> eliminarRepetidos(List<Req_Cargo> rc)
        {
            for (int i = 0; i < rc.Count-1; i++)
            {
                int j=i+1;
                while ( j < rc.Count)
                {
                    if(rc.ElementAt(i).Id_Req == rc.ElementAt(j).Id_Req)
                    {
                        rc.RemoveAt(j);
                    }else
                        j++;
                }
            }
            return rc;
        }
    }
}
