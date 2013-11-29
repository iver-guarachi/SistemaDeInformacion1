using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RRHH.Entidades;

namespace RRHH.Presentacion
{
    public partial class CrearUsuario : Form
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        UsuarioControl usuarios = new UsuarioControl();
        public CrearUsuario()
        {
            InitializeComponent();
            
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {   
            usuarios.insertarUsuairo(textBoxNombre.Text, textBoxNuevoPassword.Text, textBoxConfirmarPassword.Text, textBoxSecreta.Text, comboBox1.Text, Convert.ToInt32(comboBox2.SelectedValue));
            textBoxNombre.Text = textBoxNuevoPassword.Text = textBoxConfirmarPassword.Text = textBoxSecreta.Text = "";
            this.usuarioTableAdapter.Fill(this.recursosHumanosDataSet_HastaDescuento.Usuario);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSetVistasFinal.Empleados_NombreCompleto' Puede moverla o quitarla según sea necesario.
            this.empleados_NombreCompletoTableAdapter.Fill(this.recursosHumanosDataSetVistasFinal.Empleados_NombreCompleto);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet_HastaDescuento.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.recursosHumanosDataSet_HastaDescuento.Rol);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet_HastaDescuento.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.recursosHumanosDataSet_HastaDescuento.Usuario);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNombre.Text = listBox1.Text;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            usuarios.eliminarUsuairo(textBoxNombre.Text);
            this.usuarioTableAdapter.Fill(this.recursosHumanosDataSet_HastaDescuento.Usuario);
            textBoxNombre.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
    }
}
