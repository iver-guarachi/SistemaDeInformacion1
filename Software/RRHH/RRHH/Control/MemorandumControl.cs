using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;
using System.Windows.Forms;

namespace RRHH.Control
{
    class MemorandumControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        public void insertarMemorandum(int idEmpleado, DateTime fecha, String motivo)
        {
            Memorandum memo = new Memorandum();
            memo.id_Empleado = idEmpleado;
            memo.Fecha = fecha;
            memo.Motivo = motivo;
            rrhh.Memoranda.AddObject(memo);
            rrhh.SaveChanges();
            MessageBox.Show("se ha Agregado el Memorandum");
        }
    }
}
