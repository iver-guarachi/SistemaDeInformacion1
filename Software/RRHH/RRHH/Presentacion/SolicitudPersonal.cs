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
    public partial class SolicitudPersonal : Form
    {
        SolicitudPersonalControl spc = new SolicitudPersonalControl();
        public SolicitudPersonal()
        {
            InitializeComponent();
        }

        private void SolicitudPersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet2.SolicitudPersonal' Puede moverla o quitarla según sea necesario.
            this.solicitudPersonalTableAdapter.Fill(this.recursosHumanosDataSet2.SolicitudPersonal);           
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.Cargo' Puede moverla o quitarla según sea necesario.
            this.cargoTableAdapter.Fill(this.recursosHumanosDataSet1.Cargo);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSetVistas.SolicitudVigente' Puede moverla o quitarla según sea necesario.
            this.solicitudVigenteTableAdapter.Fill(this.recursosHumanosDataSetVistas.SolicitudVigente);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.RegistroPostulantes' Puede moverla o quitarla según sea necesario.
            comboBoxCargo.SelectedIndex = 0;
        }

        private void buttonCrearCargo_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo(this);
            cargo.Show();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            spc.insertarSolicitdPersonal(textBoxNombre.Text, Convert.ToInt32(numericUpDownVacantes.Value), dateTimePickerInicio.Value, dateTimePickerFin.Value, comboBoxCargo.Text);
            this.solicitudPersonalTableAdapter.Fill(this.recursosHumanosDataSet2.SolicitudPersonal);    
        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxReq.Items.Clear();
                List<String> nr = new List<String>();
                nr = spc.cargarRequisitos(comboBoxCargo.Text);
                foreach (var n in nr)
                {
                    listBoxReq.Items.Add(n);
                }
            }
            catch
            { }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            spc.modificarSolicitud(listBox2.Text, textBoxNombre.Text, Convert.ToInt32(numericUpDownVacantes.Value), dateTimePickerInicio.Value, dateTimePickerFin.Value, comboBoxCargo.Text);
            this.solicitudPersonalTableAdapter.Fill(this.recursosHumanosDataSet2.SolicitudPersonal);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String ca = listBox2.GetItemText(listBox2.SelectedItem);
                RRHH.Entidades.SolicitudPersonal c = new Entidades.SolicitudPersonal();
                RRHH.Entidades.RecursosHumanosEntities rrhh = new RRHH.Entidades.RecursosHumanosEntities();
                c = rrhh.SolicitudPersonals.FirstOrDefault(a => a.NombreSolicitud == ca);
                textBoxNombre.Text = c.NombreSolicitud;
                numericUpDownVacantes.Value = c.NroVacantes;
                dateTimePickerInicio.Value = c.Fecha_creacion;
                dateTimePickerFin.Value = c.Fecha_Expiracion;

                RRHH.Entidades.Cargo d = new Entidades.Cargo();
                d = rrhh.Cargoes.FirstOrDefault(a => a.Id_Departamento == c.Id_Cargo);
                //int aux = comboBoxDept.Items.IndexOf(d.Nombre);
                comboBoxCargo.SelectedItem = comboBoxCargo.Items.IndexOf(d.Nombre);               
            }
            catch
            {

            }
        }

        internal void refresh()
        {
            this.cargoTableAdapter.Fill(this.recursosHumanosDataSet1.Cargo);
        }
    }
}
