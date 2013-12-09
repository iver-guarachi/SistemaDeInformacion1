namespace RRHH.Presentacion
{
    partial class Falta
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.empleadosNombreCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetFinalVsitas2 = new RRHH.RecursosHumanosDataSetFinalVsitas2();
            this.dateTimePickerFechaReg = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.empleados_NombreCompletoTableAdapter = new RRHH.RecursosHumanosDataSetFinalVsitas2TableAdapters.Empleados_NombreCompletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetFinalVsitas2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.empleadosNombreCompletoBindingSource;
            this.comboBox1.DisplayMember = "NombreCompleto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 22;
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
            // dateTimePickerFechaReg
            // 
            this.dateTimePickerFechaReg.Enabled = false;
            this.dateTimePickerFechaReg.Location = new System.Drawing.Point(19, 84);
            this.dateTimePickerFechaReg.Name = "dateTimePickerFechaReg";
            this.dateTimePickerFechaReg.Size = new System.Drawing.Size(255, 20);
            this.dateTimePickerFechaReg.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Empleado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 167);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 86);
            this.textBox1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Motivo:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Justificada";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(152, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sin Justificacion";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // empleados_NombreCompletoTableAdapter
            // 
            this.empleados_NombreCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // Falta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 336);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePickerFechaReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Falta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Falta";
            this.Load += new System.EventHandler(this.Falta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetFinalVsitas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private RecursosHumanosDataSetFinalVsitas2 recursosHumanosDataSetFinalVsitas2;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource;
        private RecursosHumanosDataSetFinalVsitas2TableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter;
    }
}