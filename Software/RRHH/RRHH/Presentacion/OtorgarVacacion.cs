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
    public partial class OtorgarVacacion : Form
    {
        OtorgarVacacionControl ovac = new OtorgarVacacionControl();
        public OtorgarVacacion()
        {
            InitializeComponent();
        }

        private void OtorgarVacacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSetVistas2.Empleados_NombreCompleto' Puede moverla o quitarla según sea necesario.
            this.empleados_NombreCompletoTableAdapter.Fill(this.recursosHumanosDataSetVistas2.Empleados_NombreCompleto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ovac.insertarOtorgarVacacion(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
