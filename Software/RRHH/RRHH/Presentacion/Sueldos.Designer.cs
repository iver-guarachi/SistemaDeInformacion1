﻿namespace RRHH.Presentacion
{
    partial class Sueldos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteSueldosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaFinal3 = new RRHH.VistaFinal3();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteSueldosTableAdapter = new RRHH.VistaFinal3TableAdapters.ReporteSueldosTableAdapter();
            this.reporteSueldosDS = new RRHH.ReporteSueldosDS();
            this.reporteSueldosDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteSueldosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reporteSueldosTableAdapter1 = new RRHH.ReporteSueldosDSTableAdapters.ReporteSueldosTableAdapter();
            this.reporteSueldosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reporteSueldosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFinal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteSueldosBindingSource
            // 
            this.reporteSueldosBindingSource.DataMember = "ReporteSueldos";
            this.reporteSueldosBindingSource.DataSource = this.vistaFinal3;
            // 
            // vistaFinal3
            // 
            this.vistaFinal3.DataSetName = "VistaFinal3";
            this.vistaFinal3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exportar a Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(869, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exportar a PDF";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReporteSueldos1";
            reportDataSource1.Value = this.reporteSueldosBindingSource3;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RRHH.Reportes.ReportSueldos1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(956, 444);
            this.reportViewer1.TabIndex = 3;
            // 
            // reporteSueldosTableAdapter
            // 
            this.reporteSueldosTableAdapter.ClearBeforeFill = true;
            // 
            // reporteSueldosDS
            // 
            this.reporteSueldosDS.DataSetName = "ReporteSueldosDS";
            this.reporteSueldosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteSueldosDSBindingSource
            // 
            this.reporteSueldosDSBindingSource.DataSource = this.reporteSueldosDS;
            this.reporteSueldosDSBindingSource.Position = 0;
            // 
            // reporteSueldosBindingSource1
            // 
            this.reporteSueldosBindingSource1.DataMember = "ReporteSueldos";
            this.reporteSueldosBindingSource1.DataSource = this.reporteSueldosDSBindingSource;
            // 
            // reporteSueldosTableAdapter1
            // 
            this.reporteSueldosTableAdapter1.ClearBeforeFill = true;
            // 
            // reporteSueldosBindingSource2
            // 
            this.reporteSueldosBindingSource2.DataMember = "ReporteSueldos";
            this.reporteSueldosBindingSource2.DataSource = this.reporteSueldosDSBindingSource;
            // 
            // reporteSueldosBindingSource3
            // 
            this.reporteSueldosBindingSource3.DataMember = "ReporteSueldos";
            this.reporteSueldosBindingSource3.DataSource = this.reporteSueldosDSBindingSource;
            // 
            // Sueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 444);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Sueldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sueldos";
            this.Load += new System.EventHandler(this.Sueldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFinal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSueldosBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private VistaFinal3 vistaFinal3;
        private System.Windows.Forms.BindingSource reporteSueldosBindingSource;
        private VistaFinal3TableAdapters.ReporteSueldosTableAdapter reporteSueldosTableAdapter;
        private ReporteSueldosDS reporteSueldosDS;
        private System.Windows.Forms.BindingSource reporteSueldosDSBindingSource;
        private System.Windows.Forms.BindingSource reporteSueldosBindingSource1;
        private ReporteSueldosDSTableAdapters.ReporteSueldosTableAdapter reporteSueldosTableAdapter1;
        private System.Windows.Forms.BindingSource reporteSueldosBindingSource2;
        private System.Windows.Forms.BindingSource reporteSueldosBindingSource3;
    }
}