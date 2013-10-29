using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RRHH.Control;

namespace RRHH.Presentacion
{
    public partial class Rol : Form
    {   

        RolControl rols = new RolControl();
        public Rol()
        {
            InitializeComponent();            
        }

        private void Rol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter1.Fill(this.recursosHumanosDataSet1.Rol);          
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            rols.insertarRol(textBoxNombre.Text);
            this.rolTableAdapter1.Fill(this.recursosHumanosDataSet1.Rol);
            textBoxNombre.Text = "";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SeleccionarRol(object sender, EventArgs e)
        {
            textBoxNombre.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            
            rols.modificarRol(textBoxNombre.Text, listBox1.GetItemText(listBox1.SelectedItem));
            this.rolTableAdapter1.Fill(this.recursosHumanosDataSet1.Rol);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
            rols.eliminarRol(textBoxNombre.Text);
            this.rolTableAdapter1.Fill(this.recursosHumanosDataSet1.Rol);

        }

    


    }
}
