using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;
using System.Windows.Forms;

namespace RRHH.Control
{
    class DescuentoControl
    {
        RegistroAsistencia reg = new RegistroAsistencia();
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        public void insertarDescuento(int idEmpleado, int idTipo, String Motivo, decimal monto, DateTime fecha)
        {
            Descuento des = new Descuento();
            des.idTpoDescuento = idTipo;
            des.id_Empleado = idEmpleado;
            des.motivo = Motivo;
            des.monto = monto;
            des.fecha = fecha;
            rrhh.Descuentoes.AddObject(des);
            rrhh.SaveChanges();
            MessageBox.Show("Se ha guardado exitosamente");

        }
    }
}
