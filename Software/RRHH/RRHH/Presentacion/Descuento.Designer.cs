namespace RRHH.Presentacion
{
    partial class Descuento
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
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tipoDescuentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetHastaDescuentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSet_HastaDescuento = new RRHH.RecursosHumanosDataSet_HastaDescuento();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.empleadosNombreCompletoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vistaFinal3 = new RRHH.VistaFinal3();
            this.empleadosNombreCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetVistas2 = new RRHH.RecursosHumanosDataSetVistas2();
            this.empleados_NombreCompletoTableAdapter = new RRHH.RecursosHumanosDataSetVistas2TableAdapters.Empleados_NombreCompletoTableAdapter();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoDescuentoTableAdapter = new RRHH.RecursosHumanosDataSet_HastaDescuentoTableAdapters.TipoDescuentoTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.empleados_NombreCompletoTableAdapter1 = new RRHH.VistaFinal3TableAdapters.Empleados_NombreCompletoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDescuentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetHastaDescuentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet_HastaDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFinal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(282, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Motivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tipo de Descuento:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tipoDescuentoBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "id_tpoDescuento";
            // 
            // tipoDescuentoBindingSource
            // 
            this.tipoDescuentoBindingSource.DataMember = "TipoDescuento";
            this.tipoDescuentoBindingSource.DataSource = this.recursosHumanosDataSetHastaDescuentoBindingSource;
            // 
            // recursosHumanosDataSetHastaDescuentoBindingSource
            // 
            this.recursosHumanosDataSetHastaDescuentoBindingSource.DataSource = this.recursosHumanosDataSet_HastaDescuento;
            this.recursosHumanosDataSetHastaDescuentoBindingSource.Position = 0;
            // 
            // recursosHumanosDataSet_HastaDescuento
            // 
            this.recursosHumanosDataSet_HastaDescuento.DataSetName = "RecursosHumanosDataSet_HastaDescuento";
            this.recursosHumanosDataSet_HastaDescuento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(158, 229);
            this.textBoxMotivo.Multiline = true;
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(327, 68);
            this.textBoxMotivo.TabIndex = 25;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.empleadosNombreCompletoBindingSource1;
            this.comboBox2.DisplayMember = "NombreCompleto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.ValueMember = "Id_Empleado";
            // 
            // empleadosNombreCompletoBindingSource1
            // 
            this.empleadosNombreCompletoBindingSource1.DataMember = "Empleados_NombreCompleto";
            this.empleadosNombreCompletoBindingSource1.DataSource = this.vistaFinal3;
            // 
            // vistaFinal3
            // 
            this.vistaFinal3.DataSetName = "VistaFinal3";
            this.vistaFinal3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // empleados_NombreCompletoTableAdapter
            // 
            this.empleados_NombreCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(158, 190);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(327, 20);
            this.textBoxMonto.TabIndex = 28;
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Monto:";
            // 
            // tipoDescuentoTableAdapter
            // 
            this.tipoDescuentoTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha:";
            // 
            // empleados_NombreCompletoTableAdapter1
            // 
            this.empleados_NombreCompletoTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RRHH.Properties.Resources.Copia_de_logo_rifolgad_1_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // Descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBoxMotivo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Descuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuento";
            this.Load += new System.EventHandler(this.Descuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoDescuentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetHastaDescuentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet_HastaDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFinal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.ComboBox comboBox2;
        private RecursosHumanosDataSetVistas2 recursosHumanosDataSetVistas2;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource;
        private RecursosHumanosDataSetVistas2TableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource recursosHumanosDataSetHastaDescuentoBindingSource;
        private RecursosHumanosDataSet_HastaDescuento recursosHumanosDataSet_HastaDescuento;
        private System.Windows.Forms.BindingSource tipoDescuentoBindingSource;
        private RecursosHumanosDataSet_HastaDescuentoTableAdapters.TipoDescuentoTableAdapter tipoDescuentoTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private VistaFinal3 vistaFinal3;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource1;
        private VistaFinal3TableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}