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
    public partial class Privilegios : Form
    {
        public Privilegios()
        {
            InitializeComponent();
        }

        private void Privilegios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'completoContratacion.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.completoContratacion.Rol);

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            List<String> formularios = new List<String>();
            foreach (var item in checkedListBoxFormularios.CheckedItems)
            {
                formularios.Add(item.ToString());
            }
            PrivilegioControl pri = new PrivilegioControl();
            pri.insertarPrivilegio(Convert.ToInt32(comboBox1.SelectedValue), formularios);
            for (int i = 0; i < checkedListBoxFormularios.Items.Count; i++)
            {
                checkedListBoxFormularios.SetItemChecked(i, false);
            }
           // comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrivilegioControl pri = new PrivilegioControl();
            List<String> formularios = pri.obtenerPrivilegios(Convert.ToInt32(comboBox1.SelectedValue));
            for (int i = 0; i < checkedListBoxFormularios.Items.Count; i++) 
            {
                checkedListBoxFormularios.SetItemChecked(i, false);
            }
            for (int i = 0; i < formularios.Count(); i++)
            {
                checkedListBoxFormularios.SetItemChecked(checkedListBoxFormularios.FindStringExact(formularios.ElementAt(i)),true);
            }
        }
    }
}
