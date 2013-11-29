namespace RRHH.Presentacion
{
    partial class Memrandum
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.empleadosNombreCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetVistas2 = new RRHH.RecursosHumanosDataSetVistas2();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.empleados_NombreCompletoTableAdapter = new RRHH.RecursosHumanosDataSetVistas2TableAdapters.Empleados_NombreCompletoTableAdapter();
            this.recursosHumanosDataSetVistasFinal = new RRHH.RecursosHumanosDataSetVistasFinal();
            this.empleadosNombreCompletoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleados_NombreCompletoTableAdapter1 = new RRHH.RecursosHumanosDataSetVistasFinalTableAdapters.Empleados_NombreCompletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistasFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motivo:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 133);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(339, 166);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.empleadosNombreCompletoBindingSource1;
            this.comboBox1.DisplayMember = "NombreCompleto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(339, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Id_Empleado";
            // 
            // empleadosNombreCompletoBindingSource
            // 
            this.empleadosNombreCompletoBindingSource.DataMember = "Empleados_NombreCompleto";
            this.empleadosNombreCompletoBindingSource.DataSource = this.recursosHumanosDataSetVistas2;
            // 
            // recursosHumanosDataSetVistas2
            // 
            this.recursosHumanosDataSetVistas2.DataSetName = "RecursosHumanosDataSetVistas2";
            this.recursosHumanosDataSetVistas2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // empleados_NombreCompletoTableAdapter
            // 
            this.empleados_NombreCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // recursosHumanosDataSetVistasFinal
            // 
            this.recursosHumanosDataSetVistasFinal.DataSetName = "RecursosHumanosDataSetVistasFinal";
            this.recursosHumanosDataSetVistasFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosNombreCompletoBindingSource1
            // 
            this.empleadosNombreCompletoBindingSource1.DataMember = "Empleados_NombreCompleto";
            this.empleadosNombreCompletoBindingSource1.DataSource = this.recursosHumanosDataSetVistasFinal;
            // 
            // empleados_NombreCompletoTableAdapter1
            // 
            this.empleados_NombreCompletoTableAdapter1.ClearBeforeFill = true;
            // 
            // Memrandum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 380);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Memrandum";
            this.Text = "Memrandum";
            this.Load += new System.EventHandler(this.Memrandum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistasFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private RecursosHumanosDataSetVistas2 recursosHumanosDataSetVistas2;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource;
        private RecursosHumanosDataSetVistas2TableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter;
        private RecursosHumanosDataSetVistasFinal recursosHumanosDataSetVistasFinal;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource1;
        private RecursosHumanosDataSetVistasFinalTableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter1;
    }
}