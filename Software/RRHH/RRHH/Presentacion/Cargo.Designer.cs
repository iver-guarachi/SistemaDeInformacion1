namespace RRHH.Presentacion
{
    partial class Cargo
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSet1 = new RRHH.RecursosHumanosDataSet1();
            this.buttonCrearRequisitos = new System.Windows.Forms.Button();
            this.checkedListBoxReq = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new RRHH.RecursosHumanosDataSet1TableAdapters.DepartamentoTableAdapter();
            this.bindingSourceReq = new System.Windows.Forms.BindingSource(this.components);
            this.requisitosTableAdapter = new RRHH.RecursosHumanosDataSet1TableAdapters.RequisitosTableAdapter();
            this.cargoTableAdapter = new RRHH.RecursosHumanosDataSet1TableAdapters.CargoTableAdapter();
            this.recursosHumanosDataSetListaReqCargo = new RRHH.RecursosHumanosDataSetListaReqCargo();
            this.listaReqCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_Req_CargoTableAdapter = new RRHH.RecursosHumanosDataSetListaReqCargoTableAdapters.Lista_Req_CargoTableAdapter();
            this.recursosHumanosDataSet2 = new RRHH.RecursosHumanosDataSet2();
            this.departamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter1 = new RRHH.RecursosHumanosDataSet2TableAdapters.DepartamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetListaReqCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaReqCargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo Maximo";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(296, 37);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(167, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(296, 76);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(167, 20);
            this.textBoxMin.TabIndex = 4;
            this.textBoxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMin_KeyPress);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(301, 114);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(162, 20);
            this.textBoxMax.TabIndex = 5;
            this.textBoxMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMax_KeyPress);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(215, 407);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(319, 407);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(424, 407);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.Text = "Eiminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(523, 407);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.cargoBindingSource;
            this.listBox1.DisplayMember = "Nombre";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 407);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // buttonCrearRequisitos
            // 
            this.buttonCrearRequisitos.Location = new System.Drawing.Point(523, 201);
            this.buttonCrearRequisitos.Name = "buttonCrearRequisitos";
            this.buttonCrearRequisitos.Size = new System.Drawing.Size(75, 50);
            this.buttonCrearRequisitos.TabIndex = 12;
            this.buttonCrearRequisitos.Text = "Crear Requisitos";
            this.buttonCrearRequisitos.UseVisualStyleBackColor = true;
            this.buttonCrearRequisitos.Click += new System.EventHandler(this.buttonCrearRequisitos_Click);
            // 
            // checkedListBoxReq
            // 
            this.checkedListBoxReq.FormattingEnabled = true;
            this.checkedListBoxReq.Location = new System.Drawing.Point(296, 201);
            this.checkedListBoxReq.Name = "checkedListBoxReq";
            this.checkedListBoxReq.Size = new System.Drawing.Size(221, 199);
            this.checkedListBoxReq.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Requisitos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Departamento:";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.DataSource = this.departamentoBindingSource1;
            this.comboBoxDept.DisplayMember = "Nombre";
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(301, 159);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(162, 21);
            this.comboBoxDept.TabIndex = 16;
            this.comboBoxDept.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.recursosHumanosDataSet1;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceReq
            // 
            this.bindingSourceReq.DataMember = "Requisitos";
            this.bindingSourceReq.DataSource = this.recursosHumanosDataSet1;
            // 
            // requisitosTableAdapter
            // 
            this.requisitosTableAdapter.ClearBeforeFill = true;
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
            // recursosHumanosDataSet2
            // 
            this.recursosHumanosDataSet2.DataSetName = "RecursosHumanosDataSet2";
            this.recursosHumanosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoBindingSource1
            // 
            this.departamentoBindingSource1.DataMember = "Departamento";
            this.departamentoBindingSource1.DataSource = this.recursosHumanosDataSet2;
            // 
            // departamentoTableAdapter1
            // 
            this.departamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 438);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBoxReq);
            this.Controls.Add(this.buttonCrearRequisitos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cargo";
            this.Text = "Cargo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cargo_FormClosed);
            this.Load += new System.EventHandler(this.Cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetListaReqCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaReqCargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonCrearRequisitos;
        private System.Windows.Forms.CheckedListBox checkedListBoxReq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private RecursosHumanosDataSet1 recursosHumanosDataSet1;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private RecursosHumanosDataSet1TableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceReq;
        private RecursosHumanosDataSet1TableAdapters.RequisitosTableAdapter requisitosTableAdapter;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private RecursosHumanosDataSet1TableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.BindingSource listaReqCargoBindingSource;
        private RecursosHumanosDataSetListaReqCargo recursosHumanosDataSetListaReqCargo;
        private RecursosHumanosDataSetListaReqCargoTableAdapters.Lista_Req_CargoTableAdapter lista_Req_CargoTableAdapter;
        private RecursosHumanosDataSet2 recursosHumanosDataSet2;
        private System.Windows.Forms.BindingSource departamentoBindingSource1;
        private RecursosHumanosDataSet2TableAdapters.DepartamentoTableAdapter departamentoTableAdapter1;
    }
}