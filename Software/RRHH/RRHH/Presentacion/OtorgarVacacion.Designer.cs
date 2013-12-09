﻿namespace RRHH.Presentacion
{
    partial class OtorgarVacacion
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.empleadosNombreCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetVistas2 = new RRHH.RecursosHumanosDataSetVistas2();
            this.recursosHumanosDataSet_HastaDescuento = new RRHH.RecursosHumanosDataSet_HastaDescuento();
            this.recursosHumanosDataSetHastaDescuentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleados_NombreCompletoTableAdapter = new RRHH.RecursosHumanosDataSetVistas2TableAdapters.Empleados_NombreCompletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet_HastaDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetHastaDescuentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Fin";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(96, 192);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2013, 10, 11, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.empleadosNombreCompletoBindingSource;
            this.comboBox1.DisplayMember = "NombreCompleto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 8;
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
            // recursosHumanosDataSet_HastaDescuento
            // 
            this.recursosHumanosDataSet_HastaDescuento.DataSetName = "RecursosHumanosDataSet_HastaDescuento";
            this.recursosHumanosDataSet_HastaDescuento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recursosHumanosDataSetHastaDescuentoBindingSource
            // 
            this.recursosHumanosDataSetHastaDescuentoBindingSource.DataSource = this.recursosHumanosDataSet_HastaDescuento;
            this.recursosHumanosDataSetHastaDescuentoBindingSource.Position = 0;
            // 
            // empleados_NombreCompletoTableAdapter
            // 
            this.empleados_NombreCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // OtorgarVacacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 309);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "OtorgarVacacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtorgarVacacion";
            this.Load += new System.EventHandler(this.OtorgarVacacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetVistas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet_HastaDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetHastaDescuentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource recursosHumanosDataSetHastaDescuentoBindingSource;
        private RecursosHumanosDataSet_HastaDescuento recursosHumanosDataSet_HastaDescuento;
        private RecursosHumanosDataSetVistas2 recursosHumanosDataSetVistas2;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource;
        private RecursosHumanosDataSetVistas2TableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter;
    }
}