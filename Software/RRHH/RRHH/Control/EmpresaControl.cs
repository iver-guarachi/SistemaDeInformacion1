using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 
using System.Drawing; 
using System.Net; 
using System.Drawing.Imaging;
using RRHH.Entidades;
using System.Windows.Forms; 

namespace RRHH.Control
{

    class EmpresaControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Empresa emp;

        public void guardarEmpresa(String nombre, String direccion)
        {
            emp = new Empresa();
            emp.Nombre = nombre;
            emp.Direccion = direccion;

            rrhh.Empresas.AddObject(emp);
            rrhh.SaveChanges();
            MessageBox.Show("se ha Agregado la Empresa: " + nombre);
        }
        

        //Esta es la función que realiza la conversión

       
    }

	
}
