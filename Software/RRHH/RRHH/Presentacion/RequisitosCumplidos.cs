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
    public partial class RequisitosCumplidos : Form
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        int idpost;
        public RequisitosCumplidos(int idpost)
        {
            InitializeComponent();
            this.idpost = idpost;
        }

        private void RequisitosCumplidos_Load(object sender, EventArgs e)
        {
            var r = rrhh.listadoRequisitoPostulante(idpost);
            dataGridView1.DataSource = r;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
