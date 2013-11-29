using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;
using System.Windows.Forms;

namespace RRHH.Control
{
    class RegistroPostulantesControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        RegistroPostulante rpos = new RegistroPostulante();
        Req_Post req = new Req_Post();

        public void insertarPostulante(String Solicitud, String nombre, String apellido, String telefono, String mail,
            String CI, String Nacionalidad, String Genero, DateTime Nacimiento, int edad, String FormacionAcademica,
            String Referencias, List<String> requisitos)
        {
            try
            {
                SolicitudPersonal sp = new SolicitudPersonal();
                sp = rrhh.SolicitudPersonals.FirstOrDefault(a => a.NombreSolicitud == Solicitud);

                rpos.Nombre = nombre;
                rpos.Apellidos = apellido;
                rpos.Telefono = telefono;
                rpos.Mail = mail;
                rpos.CI = CI;
                rpos.Nacionalidad = Nacionalidad;
                rpos.Genero = Genero;
                rpos.FechaNacimiento = Nacimiento;
                rpos.Edad = edad;
                rpos.FormacioAcademica = FormacionAcademica;
                rpos.ReferenciasLaborales = Referencias;
                rpos.Id_Solicitud = sp.Id_Solicitud;

                rrhh.RegistroPostulantes.AddObject(rpos);
                rrhh.SaveChanges();

                rpos = rrhh.RegistroPostulantes.FirstOrDefault(a => a.CI == rpos.CI);
                for (int i = 0; i < requisitos.Count; i++)
                {
                    Requisito req = new Requisito();
                    String ar = requisitos.ElementAt(i);
                    req = rrhh.Requisitos.FirstOrDefault(a => a.Nombre == ar);
                    Req_Post req_pos = new Req_Post();
                    req_pos.Id_Post = rpos.Id_Postulante;
                    req_pos.Id_Req = req.Id_Requisito;

                    rrhh.Req_Post.AddObject(req_pos);
                    rrhh.SaveChanges();
                    
                }
                MessageBox.Show("Se inserto exitosamente al postulante " + nombre + " " + apellido);
            }
            catch
            {
                MessageBox.Show("Error al insertar al postulante, verifique sus datos e intente nuevamente");
            }

        }

        public List<String> cargarRequisito(String Solicitud)
        {
            try
            {
                SolicitudPersonal sol = new SolicitudPersonal();
                sol = rrhh.SolicitudPersonals.FirstOrDefault(a => a.NombreSolicitud == Solicitud);
                Cargo cargo = new Cargo();
                cargo = rrhh.Cargoes.FirstOrDefault(a => a.Id_Cargo == sol.Id_Cargo);
                var requisito = from d in rrhh.Req_Cargo
                                where d.Id_Cargo == cargo.Id_Cargo
                                orderby d.Id
                                select d;

                List<String> re = new List<String>();
                foreach (var r in requisito)
                {
                    re.Add(rrhh.Requisitos.FirstOrDefault(a => a.Id_Requisito == r.Id_Req).Nombre);
                }
                return re;
            }
            catch 
            {
                return null;
            }
        }
    }
}
