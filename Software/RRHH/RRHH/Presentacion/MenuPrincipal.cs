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

        public MenuPrincipal(Usuario usuarioLog)
        {
            InitializeComponent();
            usuario=usuarioLog;
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

       

 
    }
}
