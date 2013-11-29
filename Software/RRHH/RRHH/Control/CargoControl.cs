using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RRHH.Entidades;
using System.Windows.Forms;

namespace RRHH.Control
{
    class CargoControl
    {

        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        Cargo cargo = new Cargo();
        
        Requisito req = new Requisito();

        
        // Requisito req;

        public void insertarCargo(String Nombre, String Min, String Max, String Departamento, List<String> requisitos)
        {
            Departamento dep = new Departamento();
            dep = rrhh.Departamentoes.FirstOrDefault(a => a.Nombre == Departamento);
            cargo.Nombre = Nombre;
            cargo.sueldoMinimo = Convert.ToInt32(Min);
            cargo.sueldoMaximo = Convert.ToInt32(Max);
            cargo.Id_Departamento = dep.Id_Departamento;

            rrhh.Cargoes.AddObject(cargo);
            rrhh.SaveChanges();

            for (int i = 0; i < requisitos.Count; i++)
            {
                String ar = requisitos.ElementAt(i);
                req = rrhh.Requisitos.FirstOrDefault( a => a.Nombre == ar);
                cargo = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == cargo.Nombre);
                Req_Cargo req_car = new Req_Cargo();
                req_car.Id_Cargo = cargo.Id_Cargo;
                req_car.Id_Req = req.Id_Requisito;

                rrhh.Req_Cargo.AddObject(req_car);
                rrhh.SaveChanges();
            }
        }

        public void modificarCargo(String vNombre, String nNombre, String Min, String Max, String Departamento, List<String> requisitos)
        {

            Departamento dep = new Departamento();
            dep = rrhh.Departamentoes.FirstOrDefault(a => a.Nombre == Departamento);
            cargo = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == vNombre);
            cargo.Nombre = nNombre;
            cargo.sueldoMinimo = Convert.ToInt32(Min);
            cargo.sueldoMaximo = Convert.ToInt32(Max);
            cargo.Id_Departamento = dep.Id_Departamento;
           
            rrhh.SaveChanges();
            //buscar los requisitos en la tabla intermedia
            var requisito = from d in rrhh.Req_Cargo
                            where d.Id_Cargo == cargo.Id_Cargo
                            orderby d.Id
                            select d;
            foreach (var r in requisito)
            {
                //Req_Cargo rc = rrhh.Req_Cargo.FirstOrDefault(a => a.Id_Cargo == cargo.Id_Cargo);
                rrhh.Req_Cargo.DeleteObject(rrhh.Req_Cargo.FirstOrDefault( a => a.Id==r.Id));
                //rrhh.SaveChanges();
            }
            rrhh.SaveChanges();
            //insertar los nuevos requisitos
            for (int i = 0; i < requisitos.Count; i++)
            {
                String ar = requisitos.ElementAt(i);
                req = rrhh.Requisitos.FirstOrDefault(a => a.Nombre == ar);
                cargo = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == cargo.Nombre);
                Req_Cargo req_car = new Req_Cargo();
                req_car.Id_Cargo = cargo.Id_Cargo;
                req_car.Id_Req = req.Id_Requisito;

                rrhh.Req_Cargo.AddObject(req_car);
                rrhh.SaveChanges();
            }
        }

        public void eliminarCargo(String Nombre)
        {
            int id = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == Nombre).Id_Cargo;
            rrhh.Cargoes.DeleteObject(rrhh.Cargoes.FirstOrDefault(a => a.Nombre == Nombre));
            try
            {
                var requisito = from d in rrhh.Req_Cargo
                                where d.Id_Cargo == id
                                orderby d.Id
                                select d;
                foreach (var r in requisito)
                {
                    rrhh.Req_Cargo.DeleteObject(rrhh.Req_Cargo.FirstOrDefault(a => a.Id_Cargo == id));                    
                }
            }
            catch
            {
            }
            
            rrhh.SaveChanges();
        }

        public List<Requisito> cargarRequisitos()
        {

            try
            {
                var requisitos = from d in rrhh.Requisitos
                                 orderby d.Nombre
                                 select d;

                List<Requisito> req = new List<Requisito>();
                
                foreach (var requisito in requisitos)
                {
                    req.Add(requisito);
                }
                return req;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public List<Requisito> cargarReqModificar(String Nombre)
        {
            try
            {
                cargo = rrhh.Cargoes.FirstOrDefault(a => a.Nombre == Nombre);
                var requisito = from d in rrhh.Req_Cargo
                                where d.Id_Cargo == cargo.Id_Cargo
                                orderby d.Id
                                select d;

                List<Requisito> re = new List<Requisito>();        
                foreach (var r in requisito)
                {
                    re.Add(rrhh.Requisitos.FirstOrDefault(a => a.Id_Requisito == r.Id_Req));
                }
                return re;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
