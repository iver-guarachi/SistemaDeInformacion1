using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RRHH.Control;
using RRHH.Entidades;

namespace RRHH.Presentacion
{
    public partial class Requisito : Form
    {
        RequisitosControl req = new RequisitosControl();
        Cargo cargo;
        public Requisito()
        {
            InitializeComponent();
        }

        public Requisito(Cargo cargo)
        {
            InitializeComponent();
            this.cargo = cargo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            req.insertarRequisito(textBoxNombre.Text, textBoxDescripcion.Text);
            cargarList();
        }

        private void Requisito_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.Requisitos' Puede moverla o quitarla según sea necesario.
            this.requisitosTableAdapter.Fill(this.recursosHumanosDataSet1.Requisitos);

        }

        private void cargarList()
        {
            this.requisitosTableAdapter.Fill(this.recursosHumanosDataSet1.Requisitos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            req.modificarRequisitos(listBox1.Text, textBoxNombre.Text, textBoxDescripcion.Text);
            cargarList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String ca = listBox1.GetItemText(listBox1.SelectedItem);
                RRHH.Entidades.Requisito re = new Entidades.Requisito();
                RRHH.Entidades.RecursosHumanosEntities rrhh = new RRHH.Entidades.RecursosHumanosEntities();
                re = rrhh.Requisitos.FirstOrDefault(a => a.Nombre == ca);

                textBoxNombre.Text = re.Nombre;
                textBoxDescripcion.Text = re.Descripcion;
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            req.eliminarRequisito(textBoxNombre.Text);
            cargarList();
            textBoxDescripcion.Text="";
            textBoxNombre.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Requisito_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Entidades.Requisito> req = new List<Entidades.Requisito>();
            RecursosHumanosEntities rrhh = new RecursosHumanosEntities();

            var rq = from r in rrhh.Requisitos                     
                      select r;
            
            foreach (var rr in rq)
            {
                req.Add(rr);
            }
            try
            {
                cargo.obtenerRequisitos(req);
            }
            catch { }
        }

        
    }
}
