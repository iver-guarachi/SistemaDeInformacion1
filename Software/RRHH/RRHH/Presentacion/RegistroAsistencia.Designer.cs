namespace RRHH.Presentacion
{
    partial class RegistroAsistencia
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaReg = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHora = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.empleadosNombreCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetFinalVsitas2 = new RRHH.RecursosHumanosDataSetFinalVsitas2();
            this.checkBoxManana = new System.Windows.Forms.CheckBox();
            this.checkBoxTarde = new System.Windows.Forms.CheckBox();
            this.checkBoxSalida = new System.Windows.Forms.CheckBox();
            this.checkBoxEntrada = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.empleados_NombreCompletoTableAdapter = new RRHH.RecursosHumanosDataSetFinalVsitas2TableAdapters.Empleados_NombreCompletoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetFinalVsitas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // dateTimePickerFechaReg
            // 
            this.dateTimePickerFechaReg.Enabled = false;
            this.dateTimePickerFechaReg.Location = new System.Drawing.Point(48, 143);
            this.dateTimePickerFechaReg.Name = "dateTimePickerFechaReg";
            this.dateTimePickerFechaReg.Size = new System.Drawing.Size(255, 20);
            this.dateTimePickerFechaReg.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::RRHH.Properties.Resources.aceptar_este_hecho_tan_bien_verde_con_exito_icono_8880_96;
            this.button1.Location = new System.Drawing.Point(63, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 86);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::RRHH.Properties.Resources.cancelar_icono_4824_96;
            this.button2.Location = new System.Drawing.Point(190, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 86);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(190, 174);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMin.TabIndex = 17;
            // 
            // numericUpDownHora
            // 
            this.numericUpDownHora.Location = new System.Drawing.Point(141, 174);
            this.numericUpDownHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHora.Name = "numericUpDownHora";
            this.numericUpDownHora.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownHora.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hora:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.empleadosNombreCompletoBindingSource;
            this.comboBox1.DisplayMember = "NombreCompleto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "Id_Empleado";
            // 
            // empleadosNombreCompletoBindingSource
            // 
            this.empleadosNombreCompletoBindingSource.DataMember = "Empleados_NombreCompleto";
            this.empleadosNombreCompletoBindingSource.DataSource = this.recursosHumanosDataSetFinalVsitas2;
            // 
            // recursosHumanosDataSetFinalVsitas2
            // 
            this.recursosHumanosDataSetFinalVsitas2.DataSetName = "RecursosHumanosDataSetFinalVsitas2";
            this.recursosHumanosDataSetFinalVsitas2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxManana
            // 
            this.checkBoxManana.AutoSize = true;
            this.checkBoxManana.Location = new System.Drawing.Point(75, 92);
            this.checkBoxManana.Name = "checkBoxManana";
            this.checkBoxManana.Size = new System.Drawing.Size(65, 17);
            this.checkBoxManana.TabIndex = 19;
            this.checkBoxManana.Text = "Mañana";
            this.checkBoxManana.UseVisualStyleBackColor = true;
            this.checkBoxManana.Click += new System.EventHandler(this.checkBoxManana_Click);
            // 
            // checkBoxTarde
            // 
            this.checkBoxTarde.AutoSize = true;
            this.checkBoxTarde.Location = new System.Drawing.Point(228, 92);
            this.checkBoxTarde.Name = "checkBoxTarde";
            this.checkBoxTarde.Size = new System.Drawing.Size(54, 17);
            this.checkBoxTarde.TabIndex = 20;
            this.checkBoxTarde.Text = "Tarde";
            this.checkBoxTarde.UseVisualStyleBackColor = true;
            this.checkBoxTarde.Click += new System.EventHandler(this.checkBoxTarde_Click);
            // 
            // checkBoxSalida
            // 
            this.checkBoxSalida.AutoSize = true;
            this.checkBoxSalida.Location = new System.Drawing.Point(228, 225);
            this.checkBoxSalida.Name = "checkBoxSalida";
            this.checkBoxSalida.Size = new System.Drawing.Size(55, 17);
            this.checkBoxSalida.TabIndex = 22;
            this.checkBoxSalida.Text = "Salida";
            this.checkBoxSalida.UseVisualStyleBackColor = true;
            this.checkBoxSalida.Click += new System.EventHandler(this.checkBoxSalida_Click);
            // 
            // checkBoxEntrada
            // 
            this.checkBoxEntrada.AutoSize = true;
            this.checkBoxEntrada.Location = new System.Drawing.Point(75, 225);
            this.checkBoxEntrada.Name = "checkBoxEntrada";
            this.checkBoxEntrada.Size = new System.Drawing.Size(63, 17);
            this.checkBoxEntrada.TabIndex = 21;
            this.checkBoxEntrada.Text = "Entrada";
            this.checkBoxEntrada.UseVisualStyleBackColor = true;
            this.checkBoxEntrada.Click += new System.EventHandler(this.checkBoxEntrada_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 43);
            this.button3.TabIndex = 23;
            this.button3.Text = "Registrar Falta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // empleados_NombreCompletoTableAdapter
            // 
            this.empleados_NombreCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RRHH.Properties.Resources.Copia_de_logo_rifolgad_1_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBoxSalida);
            this.Controls.Add(this.checkBoxEntrada);
            this.Controls.Add(this.checkBoxTarde);
            this.Controls.Add(this.checkBoxManana);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.numericUpDownHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerFechaReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(393, 385);
            this.MinimumSize = new System.Drawing.Size(393, 385);
            this.Name = "RegistroAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlHorario";
            this.Load += new System.EventHandler(this.RegistroAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetFinalVsitas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxManana;
        private System.Windows.Forms.CheckBox checkBoxTarde;
        private System.Windows.Forms.CheckBox checkBoxSalida;
        private System.Windows.Forms.CheckBox checkBoxEntrada;
        private System.Windows.Forms.Button button3;
        private RecursosHumanosDataSetFinalVsitas2 recursosHumanosDataSetFinalVsitas2;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource;
        private RecursosHumanosDataSetFinalVsitas2TableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}