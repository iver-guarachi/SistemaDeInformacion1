using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;
using System.Windows.Forms;

namespace RRHH.Control
{
    class EmpleadoControl
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Empleado emp = new Empleado();

        public void insertarEmpleado(String Nombre, String apellidos, String CI, String nacionalidad, int genero, DateTime nacimiento, 
            int edad, String estadoCivil, String esposa, int hijos, String direccion, String telefono, String emergencia, String ref1,
            String ref_t1, String ref2, String ref_t2, DateTime ingreso, String cargo, int salario, int quincena, int haberBasico, int AFP)
        {
            try
            {
                Cargo cargos = new Cargo();
                cargos = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == cargo);
                emp.Nombre = Nombre;
                emp.Apellido = apellidos;
                emp.CI = Convert.ToInt32(CI);
                emp.Nacionalidad = nacionalidad;
                emp.Genero = genero;
                emp.fechaNacimiento = nacimiento;
                emp.edad = edad;
                emp.estadoCivil = estadoCivil;
                emp.nombreEsposa = esposa;
                emp.nroHijos = hijos;
                emp.direccion = direccion;
                emp.telefono = telefono;
                emp.telefonoEmergencia = emergencia;
                emp.referenciaNombre1 = ref1;
                emp.referenciaNombre2 = ref2;
                emp.referenciaTelefono1 = ref_t1;
                emp.referenciaTelefono2 = ref_t2;
                emp.fechaIngreso = ingreso;
                emp.idCargo = cargos.Id_Cargo;
                emp.salarioBasico = salario;
                emp.quincena = quincena;
                emp.haberBasico = haberBasico;
                emp.AFP = AFP;
                emp.activo = 1;

                rrhh.Empleadoes.AddObject(emp);
                rrhh.SaveChanges();
                MessageBox.Show("Se registro exitosamente al empleado " + Nombre + " " + apellidos);
            }
            catch
            {
                MessageBox.Show("Error al insertar empleado, verifique los datos e intente nuevamente");
            }
        }

        public void modificarEmpleado(String buscar, String Nombre, String apellidos, String CI, String nacionalidad, int genero, DateTime nacimiento, 
            int edad, String estadoCivil, String esposa, int hijos, String direccion, String telefono, String emergencia, String ref1,
            String ref_t1, String ref2, String ref_t2, DateTime ingreso, String cargo, int salario, int quincena, int haberBasico, int AFP)
        {
            try
            {
                Cargo cargos = new Cargo();
                cargos = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == cargo);

                Empleados_NombreCompleto empn = new Empleados_NombreCompleto();
                empn = rrhh.Empleados_NombreCompleto.FirstOrDefault(a => a.NombreCompleto == buscar);

                emp = rrhh.Empleadoes.FirstOrDefault(b => b.Id_Empleado == empn.Id_Empleado);

                emp.Nombre = Nombre;
                emp.Apellido = apellidos;
                emp.CI = Convert.ToInt32(CI);
                emp.Nacionalidad = nacionalidad;
                emp.Genero = genero;
                emp.fechaNacimiento = nacimiento;
                emp.edad = edad;
                emp.estadoCivil = estadoCivil;
                emp.nombreEsposa = esposa;
                emp.nroHijos = hijos;
                emp.direccion = direccion;
                emp.telefono = telefono;
                emp.telefonoEmergencia = emergencia;
                emp.referenciaNombre1 = ref1;
                emp.referenciaNombre2 = ref2;
                emp.referenciaTelefono1 = ref_t1;
                emp.referenciaTelefono2 = ref_t2;
                emp.fechaIngreso = ingreso;
                emp.idCargo = cargos.Id_Cargo;
                emp.salarioBasico = salario;
                emp.quincena = quincena;
                emp.AFP = AFP;
                emp.haberBasico = haberBasico;
                rrhh.SaveChanges();
                MessageBox.Show("Se ha modificado exitosamente los datos");
            }
            catch
            {
                MessageBox.Show("Error al modificar datos, verifique e intente nuevamente");
            }
        }
    }
}
