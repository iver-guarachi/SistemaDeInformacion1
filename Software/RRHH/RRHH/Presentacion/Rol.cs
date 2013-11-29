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
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet2.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.recursosHumanosDataSet2.Rol);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.Rol' Puede moverla o quitarla según sea necesario.
            //this.rolTableAdapter1.Fill(this.recursosHumanosDataSet1.Rol);          
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text == "")
                {
                    MessageBox.Show("Ingrese un Nombre de Rol ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    rols.insertarRol(textBoxNombre.Text);
                    //this.rolTableAdapter1.Fill(this.recursosHumanosDataSet1.Rol);
                    this.rolTableAdapter.Fill(this.recursosHumanosDataSet2.Rol);
                    textBoxNombre.Text = "";
                }

            }
            catch
            {
            }
            
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
            try
            {
                if(textBoxNombre.Text=="")
                {
                    MessageBox.Show("Seleccione un Rol ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { rols.modificarRol(textBoxNombre.Text, listBox1.GetItemText(listBox1.SelectedItem));
                 //this.rolTableAdapter1.Fill(this.recursosHumanosDataSet1.Rol);
                 this.rolTableAdapter.Fill(this.recursosHumanosDataSet2.Rol);
                 textBoxNombre.Text = "";
                }
            }
           
            catch{
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {if(textBoxNombre.Text=="")
                {
                    MessageBox.Show("Seleccione un Rol ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            else
               {rols.eliminarRol(textBoxNombre.Text);
                //this.rolTableAdapter1.Fill(this.recursosHumanosDataSet1.Rol);
                this.rolTableAdapter.Fill(this.recursosHumanosDataSet2.Rol);
                textBoxNombre.Text = "";
            }
            }
            
            catch
            {
                MessageBox.Show("Existen Privilegis asociados a este rol ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    


    }
}
