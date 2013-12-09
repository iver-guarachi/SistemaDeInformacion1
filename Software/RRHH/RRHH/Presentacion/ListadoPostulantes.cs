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
    public partial class ListadoPostulantes : Form
    {
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        public ListadoPostulantes()
        {
            InitializeComponent();
        }

        private void ListadoPostulantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'completoContratacion.SolicitudPersonal' Puede moverla o quitarla según sea necesario.
            this.solicitudPersonalTableAdapter2.Fill(this.completoContratacion.SolicitudPersonal);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var r = rrhh.Lista_Postulantes(Convert.ToInt32(comboBox1.SelectedValue));
            dataGridView1.DataSource = r;


        }

       

        

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Empleado em = new Empleado(dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(),
                    dataGridView1.SelectedCells[3].Value.ToString(), dataGridView1.SelectedCells[6].Value.ToString(),
                    dataGridView1.SelectedCells[7].Value.ToString(), dataGridView1.SelectedCells[5].Value.ToString(),
                    dataGridView1.SelectedCells[9].Value.ToString());
                em.Show();
            }

            if (e.Button == MouseButtons.Left)
            {
                String ci = dataGridView1.SelectedCells[3].Value.ToString();
                RegistroPostulante post = rrhh.RegistroPostulantes.FirstOrDefault(a => a.CI == ci);
                RequisitosCumplidos rc = new RequisitosCumplidos(post.Id_Postulante);
                rc.Show();
            }
        }
    }
}
