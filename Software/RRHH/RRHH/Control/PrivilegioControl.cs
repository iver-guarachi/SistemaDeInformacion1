using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;

namespace RRHH.Control
{
    class PrivilegioControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        public void insertarPrivilegio(int Rol, List<String> formularios)
        {
            var privilegios = from d in rrhh.Privilegios
                              where d.Id_Rol == Rol
                              orderby d.ID
                              select d;
            if (privilegios.Count()==0)
            {
                for (int i = 0; i < formularios.Count; i++)
                {
                    Privilegio pri = new Privilegio();
                    pri.Id_Rol = Rol;
                    pri.nombre = formularios.ElementAt(i);

                    rrhh.Privilegios.AddObject(pri);
                    rrhh.SaveChanges();
                }
            }
            else
            {
                modificarPrivilegios(Rol, formularios);
            }
        }

        public void modificarPrivilegios(int Rol, List<String> formularios)
        {
            //buscar los privilegios del rol
            var privilegios = from d in rrhh.Privilegios
                            where d.Id_Rol == Rol
                            orderby d.ID
                            select d;
            foreach (var p in privilegios)
            {
                rrhh.Privilegios.DeleteObject(rrhh.Privilegios.FirstOrDefault(a => a.ID == p.ID));
            }
            rrhh.SaveChanges();
            //insertar los nuevos requisitos
            insertarPrivilegio(Rol, formularios);
        }

        public List<String> obtenerPrivilegios(int Rol)
        {
            var privilegios = from d in rrhh.Privilegios
                              where d.Id_Rol == Rol
                              orderby d.ID
                              select d;
            List<String> formularios = new List<String>();
            foreach (var p in privilegios)
            {
                formularios.Add(p.nombre);
            }
            return formularios;
        }
    }
}
