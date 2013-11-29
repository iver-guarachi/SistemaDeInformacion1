using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;

namespace RRHH.Control
{
    class TipoDescuentoControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        public void insertarTipoDescuento(String Nombre)
        {
            TipoDescuento tpoDes = new TipoDescuento();
            tpoDes.Descripcion = Nombre;
            rrhh.TipoDescuentoes.AddObject(tpoDes);
            rrhh.SaveChanges();
        }

        public void modificarTipoDescuento(String vNombre, String nNombre)
        {
            TipoDescuento tpoDes = rrhh.TipoDescuentoes.FirstOrDefault(a => a.Descripcion == vNombre);
            tpoDes.Descripcion = nNombre;
            rrhh.SaveChanges();
        }

        public void eliminarTipoDescuento(String Nombre)
        {
            TipoDescuento tpoDes = rrhh.TipoDescuentoes.FirstOrDefault(a => a.Descripcion == Nombre);
            rrhh.TipoDescuentoes.DeleteObject(tpoDes);
            rrhh.SaveChanges();
        }

    }
}
