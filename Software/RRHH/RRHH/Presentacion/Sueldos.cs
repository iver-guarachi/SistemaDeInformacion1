using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RRHH.Presentacion
{
    public partial class Sueldos : Form
    {
        public Sueldos()
        {
            InitializeComponent();
        }

        private void Sueldos_Load(object sender, EventArgs e)
        {
// TODO: esta línea de código carga datos en la tabla 'vistaFinal3.ReporteSueldos' Puede moverla o quitarla según sea necesario.
this.reporteSueldosTableAdapter.Fill(this.vistaFinal3.ReporteSueldos);

            this.reportViewer1.RefreshReport();
        }
    }
}
