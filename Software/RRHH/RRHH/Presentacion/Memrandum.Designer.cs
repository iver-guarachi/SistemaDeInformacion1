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
            this.empleadosNombreCompletoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vistaFinal3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaFinal3 = new RRHH.VistaFinal3();
            this.empleadosNombreCompletoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetVistasFinal = new RRHH.RecursosHumanosDataSetVistasFinal();
            this.empleadosNombreCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetVistas2 = new RRHH.RecursosHumanosDataSetVistas2();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.empleados_NombreCompletoTableAdapter = new RRHH.RecursosHumanosDataSetVistas2TableAdapters.Empleados_NombreCompletoTableAdapter();
            this.empleados_NombreCompletoTableAdapter1 = new RRHH.RecursosHumanosDataSetVistasFinalTableAdapters.Empleados_NombreCompletoTableAdapter();
            this.empleados_NombreCompletoTableAdapter2 = new RRHH.VistaFinal3TableAdapters.Empleados_NombreCompletoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFinal3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFinal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistasFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::RRHH.Properties.Resources.agregar_editar_icono_6607_96;
            this.button1.Location = new System.Drawing.Point(190, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 88);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::RRHH.Properties.Resources.cancelar_icono_4824_96;
            this.button2.Location = new System.Drawing.Point(342, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 88);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.empleadosNombreCompletoBindingSource2;
            this.comboBox1.DisplayMember = "NombreCompleto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(339, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Id_Empleado";
            // 
            // empleadosNombreCompletoBindingSource2
            // 
            this.empleadosNombreCompletoBindingSource2.DataMember = "Empleados_NombreCompleto";
            this.empleadosNombreCompletoBindingSource2.DataSource = this.vistaFinal3BindingSource;
            // 
            // vistaFinal3BindingSource
            // 
            this.vistaFinal3BindingSource.DataSource = this.vistaFinal3;
            this.vistaFinal3BindingSource.Position = 0;
            // 
            // vistaFinal3
            // 
            this.vistaFinal3.DataSetName = "VistaFinal3";
            this.vistaFinal3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosNombreCompletoBindingSource1
            // 
            this.empleadosNombreCompletoBindingSource1.DataMember = "Empleados_NombreCompleto";
            this.empleadosNombreCompletoBindingSource1.DataSource = this.recursosHumanosDataSetVistasFinal;
            // 
            // recursosHumanosDataSetVistasFinal
            // 
            this.recursosHumanosDataSetVistasFinal.DataSetName = "RecursosHumanosDataSetVistasFinal";
            this.recursosHumanosDataSetVistasFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // empleados_NombreCompletoTableAdapter1
            // 
            this.empleados_NombreCompletoTableAdapter1.ClearBeforeFill = true;
            // 
            // empleados_NombreCompletoTableAdapter2
            // 
            this.empleados_NombreCompletoTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RRHH.Properties.Resources.Copia_de_logo_rifolgad_1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // Memrandum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(581, 454);
            this.MinimumSize = new System.Drawing.Size(581, 454);
            this.Name = "Memrandum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memrandum";
            this.Load += new System.EventHandler(this.Memrandum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFinal3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFinal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistasFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.BindingSource vistaFinal3BindingSource;
        private VistaFinal3 vistaFinal3;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource2;
        private VistaFinal3TableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}