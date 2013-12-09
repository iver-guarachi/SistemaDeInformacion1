using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RRHH.Entidades;
using RRHH.Presentacion;

namespace RRHH
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuario = new Usuario();
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();

        public MenuPrincipal(Usuario usuarioLog)
        {
            InitializeComponent();
            usuario = usuarioLog;
            var privilegios = from d in rrhh.Privilegios
                              where d.Id_Rol == usuario.IDRol
                              orderby d.ID
                              select d;
            List<String> privilegio = new List<String>();
            foreach (var p in privilegios)
            {
                if (crearUsuarioToolStripMenuItem.Text == p.nombre)
                    crearUsuarioToolStripMenuItem.Enabled = true;

                if (modificarDatosToolStripMenuItem.Text == p.nombre)
                    modificarDatosToolStripMenuItem.Enabled = true;

                if (rolToolStripMenuItem.Text == p.nombre)
                    rolToolStripMenuItem.Enabled = true;

                if (privilegiosToolStripMenuItem.Text == p.nombre)
                    privilegiosToolStripMenuItem.Enabled = true;

                if (empresaToolStripMenuItem.Text == p.nombre)
                    empresaToolStripMenuItem.Enabled = true;

                if (departamentosToolStripMenuItem.Text == p.nombre)
                    departamentosToolStripMenuItem.Enabled = true;

                if (cargosToolStripMenuItem.Text == p.nombre)
                    cargosToolStripMenuItem.Enabled = true;

                if (horariosToolStripMenuItem.Text == p.nombre)
                    horariosToolStripMenuItem.Enabled = true;

                if (registroDeSueldosToolStripMenuItem.Text == p.nombre)
                    registroDeSueldosToolStripMenuItem.Enabled = true;

                if (tipoDeDescuentoToolStripMenuItem.Text == p.nombre)
                    tipoDeDescuentoToolStripMenuItem.Enabled = true;

                if (descuentosToolStripMenuItem.Text == p.nombre)
                    descuentosToolStripMenuItem.Enabled = true;

                if (retiroDeEmpleadosToolStripMenuItem.Text == p.nombre)
                    retiroDeEmpleadosToolStripMenuItem.Enabled = true;

                if (requisistosToolStripMenuItem.Text == p.nombre)
                    requisistosToolStripMenuItem.Enabled = true;

                if (solicitudDePersonalToolStripMenuItem.Text == p.nombre)
                    solicitudDePersonalToolStripMenuItem.Enabled = true;

                if (postulantesToolStripMenuItem.Text == p.nombre)
                    postulantesToolStripMenuItem.Enabled = true;

                if (listaDePostulantesToolStripMenuItem.Text == p.nombre)
                    listaDePostulantesToolStripMenuItem.Enabled = true;

                if (registroDeAsistenciaToolStripMenuItem.Text == p.nombre)
                    registroDeAsistenciaToolStripMenuItem.Enabled = true;

                if (registrarEmpleadosToolStripMenuItem.Text == p.nombre)
                    registrarEmpleadosToolStripMenuItem.Enabled = true;

                if (vacacionesToolStripMenuItem.Text == p.nombre)
                    vacacionesToolStripMenuItem.Enabled = true;

                if (otorgarVacacionToolStripMenuItem.Text == p.nombre)
                    otorgarVacacionToolStripMenuItem.Enabled = true;

                if (memorandumToolStripMenuItem.Text == p.nombre)
                    memorandumToolStripMenuItem.Enabled = true;

                if (contenidoToolStripMenuItem.Text == p.nombre)
                    contenidoToolStripMenuItem.Enabled = true;

                if (índiceToolStripMenuItem.Text == p.nombre)
                    índiceToolStripMenuItem.Enabled = true;

                //if (buscarToolStripMenuItem.Text == p.nombre)
                //    buscarToolStripMenuItem.Enabled = true;
            }
            
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  
        }

        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario cu = new CrearUsuario();
            cu.Show();
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosUsuairo du = new DatosUsuairo(usuario);
            du.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuario cu = new CrearUsuario();
            cu.Show();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RRHH.Presentacion.Rol rol = new RRHH.Presentacion.Rol();
            rol.Show();
        }

        private void registrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RRHH.Presentacion.Empleado emp = new RRHH.Presentacion.Empleado();
            emp.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RRHH.Presentacion.Empresa emp = new RRHH.Presentacion.Empresa();
            emp.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RRHH.Presentacion.Cargo ca = new Presentacion.Cargo();
            ca.Show();
        }

        private void requisistosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RRHH.Presentacion.Requisito req = new Presentacion.Requisito();
            req.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RRHH.Presentacion.Departamento dep = new Presentacion.Departamento();
            dep.Show();
        }

        private void solicitudDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RRHH.Presentacion.SolicitudPersonal per = new Presentacion.SolicitudPersonal();
            per.Show();
        }

        private void postulantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RRHH.Presentacion.RegistroPostulantes pos = new RegistroPostulantes();
            pos.Show();
        }

        private void listaDePostulantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RRHH.Presentacion.ListadoPostulantes listpos = new ListadoPostulantes();
            listpos.Show();
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Horario hora = new Presentacion.Horario();
            hora.Show();
        }

        private void privilegiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Privilegios pri = new Privilegios();
            pri.Show();
        }

        private void registroDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAsistencia asistencia = new RegistroAsistencia();
            asistencia.Show();
        }

        private void tipoDeDescuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.TipoDescuento tdes = new Presentacion.TipoDescuento();
            tdes.Show();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Descuento des = new Presentacion.Descuento();
            des.Show();
        }

        private void memorandumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Memrandum memo = new Presentacion.Memrandum();
            memo.Show();
        }

        private void retiroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Despidos des = new Despidos();
            des.Show();
        }

        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanillaEmpleados plaemp = new PlanillaEmpleados();
            plaemp.Show();
        }

        private void índiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sueldos sueldo = new Sueldos();
            sueldo.Show();
        }

 
    }
}
