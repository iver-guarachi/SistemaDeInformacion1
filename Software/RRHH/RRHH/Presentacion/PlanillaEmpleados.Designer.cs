namespace RRHH.Presentacion
{
    partial class PlanillaEmpleados
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
            this.empleadosNombreCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetFinalVsitas2 = new RRHH.RecursosHumanosDataSetFinalVsitas2();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.empleados_NombreCompletoTableAdapter = new RRHH.RecursosHumanosDataSetFinalVsitas2TableAdapters.Empleados_NombreCompletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetFinalVsitas2)).BeginInit();
            this.SuspendLayout();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(891, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exportar a PDF";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(891, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exportar a Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportesEmpleados";
            reportDataSource1.Value = this.empleadosNombreCompletoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RRHH.Reportes.ReporteEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(976, 453);
            this.reportViewer1.TabIndex = 6;
            // 
            // empleados_NombreCompletoTableAdapter
            // 
            this.empleados_NombreCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // PlanillaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 453);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PlanillaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanillaEmpleados";
            this.Load += new System.EventHandler(this.PlanillaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetFinalVsitas2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RecursosHumanosDataSetFinalVsitas2 recursosHumanosDataSetFinalVsitas2;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource;
        private RecursosHumanosDataSetFinalVsitas2TableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter;
    }
}