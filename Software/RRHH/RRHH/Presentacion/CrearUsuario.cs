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
            usuarios.insertarUsuairo(textBoxNombre.Text, textBoxNuevoPassword.Text, textBoxConfirmarPassword.Text, textBoxSecreta.Text, comboBox1.Text);
            textBoxNombre.Text = textBoxNuevoPassword.Text = textBoxConfirmarPassword.Text = textBoxSecreta.Text = "";
            this.usuarioTableAdapter1.Fill(this.recursosHumanosDataSet2.Usuario);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {   
           
          
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.recursosHumanosDataSet.Rol);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.recursosHumanosDataSet.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet.Usuario' Puede moverla o quitarla según sea necesario.

            
          // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet2.Rol' Puede moverla o quitarla según sea necesario.
          this.rolTableAdapter1.Fill(this.recursosHumanosDataSet2.Rol);
          // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet2.Usuario' Puede moverla o quitarla según sea necesario.
          this.usuarioTableAdapter1.Fill(this.recursosHumanosDataSet2.Usuario);    
          /*ok*/

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usuarios.eliminarUsuairo(textBoxNombre.Text);
            cargarLista();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNombre.Text = listBox1.Text;
        }

        private void cargarLista()
        {

            this.usuarioTableAdapter1.Fill(this.recursosHumanosDataSet2.Usuario); 

        }
       
    }
}
