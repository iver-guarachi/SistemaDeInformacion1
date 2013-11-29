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
    public partial class Horario : Form
    {
        Control.Horario horario = new Control.Horario();
        RecursosHumanosEntities rrhh = new RecursosHumanosEntities();
        public Horario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Entrada = numericUpDownHoraEntrada.Value + ":" + numericUpDownMinEntrada.Value;
            String Salida = numericUpDownHoraSalida.Value + ":" + numericUpDownMinSalida.Value;
            horario.modificar(comboBoxNombre.Text, TimeSpan.Parse(Entrada), TimeSpan.Parse(Salida));

            numericUpDownHoraEntrada.Value = numericUpDownHoraSalida.Value = numericUpDownMinEntrada.Value = 
                numericUpDownMinSalida.Value = 0;
            comboBoxNombre.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxNombre.SelectedIndex!=-1)
            {
                Entidades.Horario hora = new Entidades.Horario();
                hora = rrhh.Horarios.FirstOrDefault(a => a.NombreTurno == comboBoxNombre.Text);
                TimeSpan horario = new TimeSpan();
                horario = hora.hraIngreso;
                numericUpDownHoraEntrada.Value = horario.Hours;
                numericUpDownMinEntrada.Value = horario.Minutes;
                horario = hora.hraSalida;
                numericUpDownHoraSalida.Value = horario.Hours;
                numericUpDownMinSalida.Value = horario.Minutes;
                
            }
        }
    }
}
