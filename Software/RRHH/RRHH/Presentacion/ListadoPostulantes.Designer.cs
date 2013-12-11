namespace RRHH.Presentacion
{
    partial class ListadoPostulantes
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
            this.solicitudPersonalBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.completoContratacion = new RRHH.completoContratacion();
            this.solicitudPersonalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSet2 = new RRHH.RecursosHumanosDataSet2();
            this.solicitudPersonalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.registroPostulantesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudPersonalTableAdapter1 = new RRHH.RecursosHumanosDataSet2TableAdapters.SolicitudPersonalTableAdapter();
            this.solicitudVigenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudVigenteTableAdapter = new RRHH.VistasTableAdapters.SolicitudVigenteTableAdapter();
            this.solicitudVigenteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registroPostulantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroPostulantesTableAdapter = new RRHH.RecursosHumanosDataSet2TableAdapters.RegistroPostulantesTableAdapter();
            this.recursosHumanosDataSet1 = new RRHH.RecursosHumanosDataSet1();
            this.solicitudPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudPersonalTableAdapter = new RRHH.RecursosHumanosDataSet1TableAdapters.SolicitudPersonalTableAdapter();
            this.solicitudPersonalBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recursosHumanosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudPersonalBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudPersonalBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudPersonalBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudPersonalTableAdapter2 = new RRHH.completoContratacionTableAdapters.SolicitudPersonalTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completoContratacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroPostulantesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudVigenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudVigenteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroPostulantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.solicitudPersonalBindingSource7;
            this.comboBox1.DisplayMember = "NombreSolicitud";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(364, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id_Solicitud";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // solicitudPersonalBindingSource7
            // 
            this.solicitudPersonalBindingSource7.DataMember = "SolicitudPersonal";
            this.solicitudPersonalBindingSource7.DataSource = this.completoContratacion;
            // 
            // completoContratacion
            // 
            this.completoContratacion.DataSetName = "completoContratacion";
            this.completoContratacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudPersonalBindingSource1
            // 
            this.solicitudPersonalBindingSource1.DataMember = "SolicitudPersonal";
            this.solicitudPersonalBindingSource1.DataSource = this.recursosHumanosDataSet2;
            // 
            // recursosHumanosDataSet2
            // 
            this.recursosHumanosDataSet2.DataSetName = "RecursosHumanosDataSet2";
            this.recursosHumanosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudPersonalBindingSource2
            // 
            this.solicitudPersonalBindingSource2.DataMember = "SolicitudPersonal";
            this.solicitudPersonalBindingSource2.DataSource = this.recursosHumanosDataSet2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Solicitud: ";
            // 
            // registroPostulantesBindingSource1
            // 
            this.registroPostulantesBindingSource1.DataMember = "RegistroPostulantes";
            this.registroPostulantesBindingSource1.DataSource = this.recursosHumanosDataSet2;
            // 
            // solicitudPersonalTableAdapter1
            // 
            this.solicitudPersonalTableAdapter1.ClearBeforeFill = true;
            // 
            // solicitudVigenteTableAdapter
            // 
            this.solicitudVigenteTableAdapter.ClearBeforeFill = true;
            // 
            // registroPostulantesBindingSource
            // 
            this.registroPostulantesBindingSource.DataMember = "RegistroPostulantes";
            this.registroPostulantesBindingSource.DataSource = this.recursosHumanosDataSet2;
            // 
            // registroPostulantesTableAdapter
            // 
            this.registroPostulantesTableAdapter.ClearBeforeFill = true;
            // 
            // recursosHumanosDataSet1
            // 
            this.recursosHumanosDataSet1.DataSetName = "RecursosHumanosDataSet1";
            this.recursosHumanosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudPersonalBindingSource
            // 
            this.solicitudPersonalBindingSource.DataMember = "SolicitudPersonal";
            this.solicitudPersonalBindingSource.DataSource = this.recursosHumanosDataSet1;
            // 
            // solicitudPersonalTableAdapter
            // 
            this.solicitudPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // solicitudPersonalBindingSource3
            // 
            this.solicitudPersonalBindingSource3.DataMember = "SolicitudPersonal";
            this.solicitudPersonalBindingSource3.DataSource = this.recursosHumanosDataSet2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 352);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // recursosHumanosDataSet1BindingSource
            // 
            this.recursosHumanosDataSet1BindingSource.DataSource = this.recursosHumanosDataSet1;
            this.recursosHumanosDataSet1BindingSource.Position = 0;
            // 
            // solicitudPersonalBindingSource4
            // 
            this.solicitudPersonalBindingSource4.DataMember = "SolicitudPersonal";
            this.solicitudPersonalBindingSource4.DataSource = this.recursosHumanosDataSet2;
            // 
            // solicitudPersonalBindingSource5
            // 
            this.solicitudPersonalBindingSource5.DataMember = "SolicitudPersonal";
            this.solicitudPersonalBindingSource5.DataSource = this.recursosHumanosDataSet2;
            // 
            // solicitudPersonalBindingSource6
            // 
            this.solicitudPersonalBindingSource6.DataMember = "SolicitudPersonal";
            this.solicitudPersonalBindingSource6.DataSource = this.recursosHumanosDataSet2;
            // 
            // solicitudPersonalTableAdapter2
            // 
            this.solicitudPersonalTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RRHH.Properties.Resources.Copia_de_logo_rifolgad_1_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // ListadoPostulantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ListadoPostulantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoPostulantes";
            this.Load += new System.EventHandler(this.ListadoPostulantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completoContratacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroPostulantesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudVigenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudVigenteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroPostulantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private RecursosHumanosDataSet2 recursosHumanosDataSet2;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource1;
        private RecursosHumanosDataSet2TableAdapters.SolicitudPersonalTableAdapter solicitudPersonalTableAdapter1;
        private System.Windows.Forms.BindingSource solicitudVigenteBindingSource;
        private VistasTableAdapters.SolicitudVigenteTableAdapter solicitudVigenteTableAdapter;
        private System.Windows.Forms.BindingSource solicitudVigenteBindingSource1;
        private System.Windows.Forms.BindingSource registroPostulantesBindingSource;
        private RecursosHumanosDataSet2TableAdapters.RegistroPostulantesTableAdapter registroPostulantesTableAdapter;
        private System.Windows.Forms.BindingSource registroPostulantesBindingSource1;
        private RecursosHumanosDataSet1 recursosHumanosDataSet1;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource;
        private RecursosHumanosDataSet1TableAdapters.SolicitudPersonalTableAdapter solicitudPersonalTableAdapter;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource2;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource recursosHumanosDataSet1BindingSource;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource4;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource5;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource6;
        private completoContratacion completoContratacion;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource7;
        private completoContratacionTableAdapters.SolicitudPersonalTableAdapter solicitudPersonalTableAdapter2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}