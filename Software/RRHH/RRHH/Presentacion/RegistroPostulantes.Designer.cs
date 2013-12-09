namespace RRHH.Presentacion
{
    partial class RegistroPostulantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxAcademico = new System.Windows.Forms.TextBox();
            this.textBoxReferencias = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.solicitudPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSet2 = new RRHH.RecursosHumanosDataSet2();
            this.checkedListBoxRequisitos = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNaciomiento = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButtonFem = new System.Windows.Forms.RadioButton();
            this.radioButtonMas = new System.Windows.Forms.RadioButton();
            this.textBoxCI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.solicitudPersonalTableAdapter = new RRHH.RecursosHumanosDataSet2TableAdapters.SolicitudPersonalTableAdapter();
            this.comboBoxNacionalidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitud:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Formacion Academica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Referencias Laborales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mail:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(95, 41);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(334, 20);
            this.textBoxNombre.TabIndex = 8;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(95, 67);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(334, 20);
            this.textBoxApellido.TabIndex = 9;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(95, 93);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(334, 20);
            this.textBoxTelefono.TabIndex = 10;
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(95, 119);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(334, 20);
            this.textBoxMail.TabIndex = 11;
            // 
            // textBoxAcademico
            // 
            this.textBoxAcademico.Location = new System.Drawing.Point(27, 175);
            this.textBoxAcademico.Multiline = true;
            this.textBoxAcademico.Name = "textBoxAcademico";
            this.textBoxAcademico.Size = new System.Drawing.Size(399, 112);
            this.textBoxAcademico.TabIndex = 12;
            // 
            // textBoxReferencias
            // 
            this.textBoxReferencias.Location = new System.Drawing.Point(455, 175);
            this.textBoxReferencias.Multiline = true;
            this.textBoxReferencias.Name = "textBoxReferencias";
            this.textBoxReferencias.Size = new System.Drawing.Size(399, 112);
            this.textBoxReferencias.TabIndex = 13;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(444, 328);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(768, 328);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.solicitudPersonalBindingSource;
            this.comboBox1.DisplayMember = "NombreSolicitud";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // solicitudPersonalBindingSource
            // 
            this.solicitudPersonalBindingSource.DataMember = "SolicitudPersonal";
            this.solicitudPersonalBindingSource.DataSource = this.recursosHumanosDataSet2;
            // 
            // recursosHumanosDataSet2
            // 
            this.recursosHumanosDataSet2.DataSetName = "RecursosHumanosDataSet2";
            this.recursosHumanosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkedListBoxRequisitos
            // 
            this.checkedListBoxRequisitos.FormattingEnabled = true;
            this.checkedListBoxRequisitos.Location = new System.Drawing.Point(25, 318);
            this.checkedListBoxRequisitos.Name = "checkedListBoxRequisitos";
            this.checkedListBoxRequisitos.Size = new System.Drawing.Size(401, 154);
            this.checkedListBoxRequisitos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Requisitos:";
            // 
            // dateTimePickerNaciomiento
            // 
            this.dateTimePickerNaciomiento.Location = new System.Drawing.Point(571, 90);
            this.dateTimePickerNaciomiento.Name = "dateTimePickerNaciomiento";
            this.dateTimePickerNaciomiento.Size = new System.Drawing.Size(221, 20);
            this.dateTimePickerNaciomiento.TabIndex = 52;
            this.dateTimePickerNaciomiento.ValueChanged += new System.EventHandler(this.dateTimePickerNaciomiento_ValueChanged);
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(571, 118);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEdad.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(451, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Fecha de Nacimiento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(451, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Edad:";
            // 
            // radioButtonFem
            // 
            this.radioButtonFem.AutoSize = true;
            this.radioButtonFem.Location = new System.Drawing.Point(660, 67);
            this.radioButtonFem.Name = "radioButtonFem";
            this.radioButtonFem.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFem.TabIndex = 48;
            this.radioButtonFem.TabStop = true;
            this.radioButtonFem.Text = "Femenino";
            this.radioButtonFem.UseVisualStyleBackColor = true;
            // 
            // radioButtonMas
            // 
            this.radioButtonMas.AutoSize = true;
            this.radioButtonMas.Location = new System.Drawing.Point(564, 67);
            this.radioButtonMas.Name = "radioButtonMas";
            this.radioButtonMas.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMas.TabIndex = 47;
            this.radioButtonMas.TabStop = true;
            this.radioButtonMas.Text = "Masculino";
            this.radioButtonMas.UseVisualStyleBackColor = true;
            // 
            // textBoxCI
            // 
            this.textBoxCI.Location = new System.Drawing.Point(561, 15);
            this.textBoxCI.Name = "textBoxCI";
            this.textBoxCI.Size = new System.Drawing.Size(294, 20);
            this.textBoxCI.TabIndex = 45;
            this.textBoxCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCI_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Genero:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Nacionalidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Cedula de Identidad:";
            // 
            // solicitudPersonalTableAdapter
            // 
            this.solicitudPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxNacionalidad
            // 
            this.comboBoxNacionalidad.FormattingEnabled = true;
            this.comboBoxNacionalidad.Items.AddRange(new object[] {
            "Afganistán",
            "Akrotiri",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Anguila",
            "Antártida",
            "Antigua y Barbuda",
            "Antillas Neerlandesas",
            "Arabia Saudí",
            "Arctic Ocean",
            "Argelia",
            "Argentina",
            "Armenia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bahráin",
            "Bangladesh",
            "Barbados",
            "Bélgica",
            "Belice",
            "Benín",
            "Bermudas",
            "Bielorrusia",
            "Birmania; Myanmar",
            "Bolivia",
            "Bosnia y Hercegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colombia",
            "Comoras",
            "Congo",
            "Coral Sea Islands",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dhekelia",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "El Vaticano",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Gaza Strip",
            "Georgia",
            "Ghana",
            "Gibraltar",
            "Granada",
            "Grecia",
            "Groenlandia",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea Ecuatorial",
            "Guinea-Bissau",
            "Guyana",
            "Haití",
            "Honduras",
            "Hong Kong",
            "Hungría",
            "India",
            "Indian Ocean",
            "Indonesia",
            "Irán",
            "Iraq",
            "Irlanda",
            "Isla Bouvet",
            "Isla Christmas",
            "Isla Norfolk",
            "Islandia",
            "Islas Caimán",
            "Islas Cocos",
            "Islas Cook",
            "Islas Feroe",
            "Islas Georgia del Sur y Sandwich del Sur",
            "Islas Heard y McDonald",
            "Islas Malvinas",
            "Islas Marianas del Norte",
            "Islas Marshall",
            "Islas Pitcairn",
            "Islas Salomón",
            "Islas Turcas y Caicos",
            "Islas Vírgenes Americanas",
            "Islas Vírgenes Británicas",
            "Israel",
            "Italia",
            "Jamaica",
            "Jan Mayen",
            "Japón",
            "Jersey",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguizistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macao",
            "Macedonia",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Man, Isle of",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "Mayotte",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Montserrat",
            "Mozambique",
            "Mundo",
            "Namibia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Niue",
            "Noruega",
            "Nueva Caledonia",
            "Nueva Zelanda",
            "Omán",
            "Pacific Ocean",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa-Nueva Guinea",
            "Paracel Islands",
            "Paraguay",
            "Perú",
            "Polinesia Francesa",
            "Polonia",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Sáhara Occidental",
            "Samoa",
            "Samoa Americana",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Pedro y Miquelón",
            "San Vicente y las Granadinas",
            "Santa Helena",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Suecia",
            "Suiza",
            "Surinam",
            "Svalbard y Jan Mayen",
            "Tailandia",
            "Taiwán",
            "Tanzania",
            "Tayikistán",
            "Territorio Británico del Océano Indico",
            "Territorios Australes Franceses",
            "Timor Oriental",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Unión Europea",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Wake Island",
            "Wallis y Futuna",
            "West Bank",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.comboBoxNacionalidad.Location = new System.Drawing.Point(561, 41);
            this.comboBoxNacionalidad.Name = "comboBoxNacionalidad";
            this.comboBoxNacionalidad.Size = new System.Drawing.Size(294, 21);
            this.comboBoxNacionalidad.TabIndex = 53;
            // 
            // RegistroPostulantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 482);
            this.Controls.Add(this.comboBoxNacionalidad);
            this.Controls.Add(this.dateTimePickerNaciomiento);
            this.Controls.Add(this.numericUpDownEdad);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.radioButtonFem);
            this.Controls.Add(this.radioButtonMas);
            this.Controls.Add(this.textBoxCI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxRequisitos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxReferencias);
            this.Controls.Add(this.textBoxAcademico);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RegistroPostulantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Postulantes";
            this.Load += new System.EventHandler(this.RegistroPostulantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxAcademico;
        private System.Windows.Forms.TextBox textBoxReferencias;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxRequisitos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNaciomiento;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioButtonFem;
        private System.Windows.Forms.RadioButton radioButtonMas;
        private System.Windows.Forms.TextBox textBoxCI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private RecursosHumanosDataSet2 recursosHumanosDataSet2;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource;
        private RecursosHumanosDataSet2TableAdapters.SolicitudPersonalTableAdapter solicitudPersonalTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxNacionalidad;
    }
}