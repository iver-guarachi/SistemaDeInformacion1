namespace RRHH.Presentacion
{
    partial class SolicitudPersonal
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
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSet1 = new RRHH.RecursosHumanosDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.buttonCrearCargo = new System.Windows.Forms.Button();
            this.numericUpDownVacantes = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxReq = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.solicitudPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSet2 = new RRHH.RecursosHumanosDataSet2();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.recursosHumanosDataSetVistas = new RRHH.RecursosHumanosDataSetVistas();
            this.solicitudVigenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudVigenteTableAdapter = new RRHH.RecursosHumanosDataSetVistasTableAdapters.SolicitudVigenteTableAdapter();
            this.cargoTableAdapter = new RRHH.RecursosHumanosDataSet1TableAdapters.CargoTableAdapter();
            this.recursosHumanosDataSetListaReqCargo = new RRHH.RecursosHumanosDataSetListaReqCargo();
            this.listaReqCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_Req_CargoTableAdapter = new RRHH.RecursosHumanosDataSetListaReqCargoTableAdapters.Lista_Req_CargoTableAdapter();
            this.solicitudPersonalTableAdapter = new RRHH.RecursosHumanosDataSet2TableAdapters.SolicitudPersonalTableAdapter();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVacantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudVigenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetListaReqCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaReqCargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Vacantes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Requisitos";
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.DataSource = this.cargoBindingSource;
            this.comboBoxCargo.DisplayMember = "Nombre";
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Location = new System.Drawing.Point(384, 52);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(194, 21);
            this.comboBoxCargo.TabIndex = 3;
            this.comboBoxCargo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCargo_SelectedIndexChanged);
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "Cargo";
            this.cargoBindingSource.DataSource = this.recursosHumanosDataSet1;
            // 
            // recursosHumanosDataSet1
            // 
            this.recursosHumanosDataSet1.DataSetName = "RecursosHumanosDataSet1";
            this.recursosHumanosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo de Solicitud ";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(321, 429);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(610, 429);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de Expiracion:";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(451, 149);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFin.TabIndex = 11;
            // 
            // buttonCrearCargo
            // 
            this.buttonCrearCargo.Location = new System.Drawing.Point(601, 50);
            this.buttonCrearCargo.Name = "buttonCrearCargo";
            this.buttonCrearCargo.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearCargo.TabIndex = 13;
            this.buttonCrearCargo.Text = "Crear Cargo";
            this.buttonCrearCargo.UseVisualStyleBackColor = true;
            this.buttonCrearCargo.Click += new System.EventHandler(this.buttonCrearCargo_Click);
            // 
            // numericUpDownVacantes
            // 
            this.numericUpDownVacantes.Location = new System.Drawing.Point(417, 84);
            this.numericUpDownVacantes.Name = "numericUpDownVacantes";
            this.numericUpDownVacantes.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownVacantes.TabIndex = 15;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(451, 123);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicio.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha de Solicitud de Inicio:";
            // 
            // listBoxReq
            // 
            this.listBoxReq.FormattingEnabled = true;
            this.listBoxReq.Location = new System.Drawing.Point(384, 175);
            this.listBoxReq.Name = "listBoxReq";
            this.listBoxReq.Size = new System.Drawing.Size(233, 238);
            this.listBoxReq.TabIndex = 14;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.solicitudPersonalBindingSource;
            this.listBox2.DisplayMember = "NombreSolicitud";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(18, 40);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(235, 407);
            this.listBox2.TabIndex = 18;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
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
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(463, 429);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 19;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // recursosHumanosDataSetVistas
            // 
            this.recursosHumanosDataSetVistas.DataSetName = "RecursosHumanosDataSetVistas";
            this.recursosHumanosDataSetVistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudVigenteBindingSource
            // 
            this.solicitudVigenteBindingSource.DataMember = "SolicitudVigente";
            this.solicitudVigenteBindingSource.DataSource = this.recursosHumanosDataSetVistas;
            // 
            // solicitudVigenteTableAdapter
            // 
            this.solicitudVigenteTableAdapter.ClearBeforeFill = true;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // recursosHumanosDataSetListaReqCargo
            // 
            this.recursosHumanosDataSetListaReqCargo.DataSetName = "RecursosHumanosDataSetListaReqCargo";
            this.recursosHumanosDataSetListaReqCargo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaReqCargoBindingSource
            // 
            this.listaReqCargoBindingSource.DataMember = "Lista_Req_Cargo";
            this.listaReqCargoBindingSource.DataSource = this.recursosHumanosDataSetListaReqCargo;
            // 
            // lista_Req_CargoTableAdapter
            // 
            this.lista_Req_CargoTableAdapter.ClearBeforeFill = true;
            // 
            // solicitudPersonalTableAdapter
            // 
            this.solicitudPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(417, 22);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(161, 20);
            this.textBoxNombre.TabIndex = 20;
            // 
            // SolicitudPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 469);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownVacantes);
            this.Controls.Add(this.listBoxReq);
            this.Controls.Add(this.buttonCrearCargo);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SolicitudPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SolicitudPersonal";
            this.Load += new System.EventHandler(this.SolicitudPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVacantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudPersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudVigenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetListaReqCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaReqCargoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Button buttonCrearCargo;
        private System.Windows.Forms.NumericUpDown numericUpDownVacantes;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxReq;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonModificar;
        private RecursosHumanosDataSetVistas recursosHumanosDataSetVistas;
        private System.Windows.Forms.BindingSource solicitudVigenteBindingSource;
        private RecursosHumanosDataSetVistasTableAdapters.SolicitudVigenteTableAdapter solicitudVigenteTableAdapter;
        private RecursosHumanosDataSet1 recursosHumanosDataSet1;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private RecursosHumanosDataSet1TableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.BindingSource listaReqCargoBindingSource;
        private RecursosHumanosDataSetListaReqCargo recursosHumanosDataSetListaReqCargo;
        private RecursosHumanosDataSetListaReqCargoTableAdapters.Lista_Req_CargoTableAdapter lista_Req_CargoTableAdapter;
        private RecursosHumanosDataSet2 recursosHumanosDataSet2;
        private System.Windows.Forms.BindingSource solicitudPersonalBindingSource;
        private RecursosHumanosDataSet2TableAdapters.SolicitudPersonalTableAdapter solicitudPersonalTableAdapter;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}