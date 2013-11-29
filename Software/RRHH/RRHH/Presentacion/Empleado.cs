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
    public partial class Empleado : Form
    {
        EmpleadoControl ec = new EmpleadoControl();
        ValidacionesControl valida = new ValidacionesControl();
        public Empleado()
        {
            InitializeComponent();
            numericUpDownHaberBasico.Enabled = false;
        }

        public Empleado(String nombre, String apellido, String CI, String mail, String Telefono, String nacionalidad, String fechanac)
        {
            InitializeComponent();
            textBoxNombre.Text = nombre;
            textBoxApellidos.Text = apellido;
            textBoxCI.Text = CI;
            textBoxTelefono.Text = Telefono;
            comboBoxNacionalidad.Text = nacionalidad;
            dateTimePickerNacimiento.Value = Convert.ToDateTime(fechanac);
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSetVistasFinal.Empleados_NombreCompleto' Puede moverla o quitarla según sea necesario.
            this.empleados_NombreCompletoTableAdapter1.Fill(this.recursosHumanosDataSetVistasFinal.Empleados_NombreCompleto);
            // TODO: esta línea de código carga datos en la tabla 'recursosHumanosDataSet1.Cargo' Puede moverla o quitarla según sea necesario.
            this.cargoTableAdapter.Fill(this.recursosHumanosDataSet1.Cargo);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String ca = listBox1.GetItemText(listBox1.SelectedItem);
                RRHH.Entidades.Empleados_NombreCompleto empc = new Entidades.Empleados_NombreCompleto();
                RRHH.Entidades.RecursosHumanosEntities rrhh = new RRHH.Entidades.RecursosHumanosEntities();
                //empc = rrhh.Empleados_NombreCompleto.FirstOrDefault(a => a.NombreCompleto == ca);
                empc = rrhh.Empleados_NombreCompleto.First(a => a.NombreCompleto == ca.Trim());

                RRHH.Entidades.Empleado emp = new Entidades.Empleado();
                emp = rrhh.Empleadoes.FirstOrDefault(a => a.Id_Empleado == empc.Id_Empleado);

                textBoxNombre.Text = emp.Nombre;
                textBoxApellidos.Text = emp.Apellido;
                textBoxCI.Text = Convert.ToString(emp.CI);
                dateTimePickerNacimiento.Value = emp.fechaNacimiento;
                if (emp.Genero == 0)
                    radioButtonFem.Checked = true;
                else
                    radioButtonMas.Checked = true;
                comboBoxNacionalidad.Text = emp.Nacionalidad;
                numericUpDownEdad.Value = emp.edad;
                comboBoxCivil.SelectedIndex = comboBoxCivil.Items.IndexOf(emp.estadoCivil);
                textBoxEsposa.Text = emp.nombreEsposa;
                numericUpDownHijos.Value = Convert.ToDecimal(emp.nroHijos);
                textBoxDireccion.Text = emp.direccion;
                textBoxTelefono.Text = emp.telefono;
                textBoxEmergencia.Text = emp.telefonoEmergencia;
                textBoxNomRef1.Text = emp.referenciaNombre1;
                textBoxNomRef2.Text = emp.referenciaNombre2;
                textBoxTelf_Ref1.Text = emp.referenciaTelefono1;
                textBoxTelf_Ref2.Text = emp.referenciaTelefono2;
                dateTimePickerIngreso.Value = emp.fechaIngreso;
                textBoxSalario.Text = Convert.ToString(emp.salarioBasico);
                numericUpDownQuincena.Value = emp.quincena;

                RRHH.Entidades.Cargo cc = new Entidades.Cargo();
                cc = rrhh.Cargoes.FirstOrDefault(a => a.Id_Cargo == emp.idCargo);
                String nom = cc.Nombre;
                comboBoxCargo.SelectedIndex = comboBoxCargo.FindString(nom);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int gene;
            if( !radioButtonFem.Checked)
                gene =1;
            else
                gene =0;

            ec.insertarEmpleado(textBoxNombre.Text, textBoxApellidos.Text, textBoxCI.Text, comboBoxNacionalidad.Text,
                gene, dateTimePickerNacimiento.Value, Convert.ToInt32(numericUpDownEdad.Value), comboBoxCivil.Text,
                textBoxEsposa.Text, Convert.ToInt32(numericUpDownHijos.Value), textBoxDireccion.Text, textBoxTelefono.Text,
                textBoxEmergencia.Text, textBoxNomRef1.Text, textBoxTelf_Ref1.Text, textBoxNomRef2.Text, textBoxTelf_Ref2.Text,
                dateTimePickerIngreso.Value, comboBoxCargo.Text, Convert.ToInt32(textBoxSalario.Text), Convert.ToInt32(totalQuincena.Text),
                Convert.ToInt32( numericUpDownHaberBasico.Value), Convert.ToInt32(labelAFP.Text));
            
            this.empleados_NombreCompletoTableAdapter1.Fill(this.recursosHumanosDataSetVistasFinal.Empleados_NombreCompleto);

            textBoxApellidos.Text = textBoxNombre.Text = textBoxCI.Text = comboBoxNacionalidad.Text = textBoxEsposa.Text = textBoxDireccion.Text =
                textBoxTelefono.Text = textBoxNomRef1.Text = textBoxTelf_Ref1.Text = textBoxNomRef2.Text = textBoxTelf_Ref2.Text = textBoxSalario.Text = textBoxEmergencia.Text = "";
            numericUpDownEdad.Value = numericUpDownQuincena.Value = numericUpDownHijos.Value = numericUpDownHaberBasico.Value = 0;
            checkBox1.Checked = false;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int gene;
            if (!radioButtonFem.Checked)
                gene = 1;
            else
                gene = 0;

            ec.modificarEmpleado(listBox1.Text, textBoxNombre.Text, textBoxApellidos.Text, textBoxCI.Text, comboBoxNacionalidad.Text,
                gene, dateTimePickerNacimiento.Value, Convert.ToInt32(numericUpDownEdad.Value), comboBoxCivil.Text,
                textBoxEsposa.Text, Convert.ToInt32(numericUpDownHijos.Value), textBoxDireccion.Text, textBoxTelefono.Text,
                textBoxEmergencia.Text, textBoxNomRef1.Text, textBoxTelf_Ref1.Text, textBoxNomRef2.Text, textBoxTelf_Ref2.Text,
               dateTimePickerIngreso.Value, comboBoxCargo.Text, Convert.ToInt32(textBoxSalario.Text), Convert.ToInt32(numericUpDownQuincena.Value),
               Convert.ToInt32( numericUpDownHaberBasico.Value), Convert.ToInt32(labelAFP.Text));
            //actualiza el listbox
            this.empleados_NombreCompletoTableAdapter.Fill(this.recursosHumanosDataSetVistas2.Empleados_NombreCompleto);
            //limpia los campos
            textBoxApellidos.Text = textBoxNombre.Text = textBoxCI.Text = comboBoxNacionalidad.Text = textBoxEsposa.Text = textBoxDireccion.Text =
                textBoxTelefono.Text = textBoxNomRef1.Text = textBoxTelf_Ref1.Text = textBoxNomRef2.Text = textBoxTelf_Ref2.Text = textBoxSalario.Text = textBoxEmergencia.Text="";
            numericUpDownEdad.Value = numericUpDownQuincena.Value = numericUpDownHijos.Value = numericUpDownHaberBasico.Value = 0;
            checkBox1.Checked = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDownQuincena_ValueChanged(object sender, EventArgs e)
        {
            totalQuincena.Text = Convert.ToString(Convert.ToInt32(textBoxSalario.Text) * Convert.ToInt32(numericUpDownQuincena.Value) / 100);
        }


        private void verificarChecked()
        {
          if (checkBox1.Checked == false)
            {
                numericUpDownHaberBasico.Enabled = false;
                numericUpDownHaberBasico.Value = 0;
            }
            else
                numericUpDownHaberBasico.Enabled = true;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            verificarChecked();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelAFP.Text = Convert.ToString(Convert.ToInt32(numericUpDownHaberBasico.Value) * 0.1271 );
        }

        private void dateTimePickerNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if( Edad(dateTimePickerNacimiento.Value) != -1)
                numericUpDownEdad.Value = Convert.ToDecimal(Edad(dateTimePickerNacimiento.Value));
        }
        public int Edad(DateTime fechaNacimiento)
        {
            //Obtengo la diferencia en años.
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            //Obtengo la fecha de cumpleaños de este año.
            DateTime nacimientoAhora = fechaNacimiento.AddYears(edad);
            //Le resto un año si la fecha actual es anterior 
            //al día de nacimiento.
            if (DateTime.Now.CompareTo(nacimientoAhora) < 0)
            {
                edad--;
            }
            return edad;
        }

       
        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxTelefono.MaxLength = 8;
            if (!valida.SoloNumeros(e.KeyChar))
            {
                MessageBox.Show("Digite solo valores numericos");
                e.Handled = true;
            }
        }

        private void textBoxEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxEmergencia.MaxLength = 8;
            if (!valida.SoloNumeros(e.KeyChar))
            {
                MessageBox.Show("Digite solo valores numericos");
                e.Handled = true;
            }
        }

        private void textBoxTelf_Ref1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxTelf_Ref1.MaxLength = 8;
            if (!valida.SoloNumeros(e.KeyChar))
            {
                MessageBox.Show("Digite solo valores numericos");
                e.Handled = true;
            }
        }

        private void textBoxTelf_Ref2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxTelf_Ref2.MaxLength = 8;
            if (!valida.SoloNumeros(e.KeyChar))
            {
                MessageBox.Show("Digite solo valores numericos");
                e.Handled = true;
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNombre.MaxLength = 35;
            if (!valida.SoloLetras(e.KeyChar))
            {
                MessageBox.Show("Digite solo Letras");
                e.Handled = true;
            }
        }

        private void textBoxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxApellidos.MaxLength = 35;
            if (!valida.SoloLetras(e.KeyChar))
            {
                MessageBox.Show("Digite solo Letras");
                e.Handled = true;
            }
        }

        private void textBoxCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxCI.MaxLength = 8;
            if (!valida.SoloNumeros(e.KeyChar))
            {
                MessageBox.Show("Digite solo valores numericos");
                e.Handled = true;
            }
        }

        private void textBoxEsposa_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxEsposa.MaxLength = 8;
            if (!valida.SoloLetras(e.KeyChar))
            {
                MessageBox.Show("Digite solo Letras");
                e.Handled = true;
            }
        }

        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxDireccion.MaxLength = 100;
        }

        private void textBoxNomRef1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNomRef1.MaxLength = 25;
            if (!valida.SoloLetras(e.KeyChar))
            {
                MessageBox.Show("Digite solo Letras");
                e.Handled = true;
            }
        }

        private void textBoxNomRef2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxNomRef2.MaxLength = 25;
            if (!valida.SoloLetras(e.KeyChar))
            {
                MessageBox.Show("Digite solo Letras");
                e.Handled = true;
            }
        }

        private void textBoxSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!valida.SoloNumeros(e.KeyChar))
            {
                MessageBox.Show("Digite solo valores numericos");
                e.Handled = true;
            }
        }
    }
}
