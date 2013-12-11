namespace RRHH.Presentacion
{
    partial class Privilegios
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
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.completoContratacion = new RRHH.completoContratacion();
            this.rolTableAdapter = new RRHH.completoContratacionTableAdapters.RolTableAdapter();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBoxFormularios = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completoContratacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rolBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.completoContratacion;
            // 
            // completoContratacion
            // 
            this.completoContratacion.DataSetName = "completoContratacion";
            this.completoContratacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Image = global::RRHH.Properties.Resources.aceptar_este_hecho_tan_bien_verde_con_exito_icono_8880_96;
            this.buttonAceptar.Location = new System.Drawing.Point(12, 446);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(100, 75);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::RRHH.Properties.Resources.cancelar_icono_4824_96;
            this.button1.Location = new System.Drawing.Point(139, 444);
            this.button1.MaximumSize = new System.Drawing.Size(113, 77);
            this.button1.MinimumSize = new System.Drawing.Size(113, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 77);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBoxFormularios
            // 
            this.checkedListBoxFormularios.FormattingEnabled = true;
            this.checkedListBoxFormularios.Items.AddRange(new object[] {
            "Crear Usuario",
            "Modificar Datos",
            "Rol",
            "Privilegios",
            "Empresa",
            "Departamentos",
            "Cargos",
            "Registro de Horarios",
            "Tipo de Descuento",
            "Descuentos",
            "Requisitos",
            "Solicitud de Personal",
            "Registro de Postulantes",
            "Lista de Postulantes",
            "Registro de Asistencia",
            "Registrar Empleados",
            "Vacaciones",
            "Otorgar Vacacion",
            "Memorandum",
            "Retiro de Empleados",
            "Planilla de Empleados",
            "Planilla de Aguinaldos",
            "Planilla de Sueldos"});
            this.checkedListBoxFormularios.Location = new System.Drawing.Point(12, 89);
            this.checkedListBoxFormularios.Name = "checkedListBoxFormularios";
            this.checkedListBoxFormularios.Size = new System.Drawing.Size(240, 349);
            this.checkedListBoxFormularios.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RRHH.Properties.Resources.Copia_de_logo_rifolgad_1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // Privilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkedListBoxFormularios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBox1);
            this.Name = "Privilegios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Privilegios";
            this.Load += new System.EventHandler(this.Privilegios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completoContratacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private completoContratacion completoContratacion;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private completoContratacionTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBoxFormularios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}