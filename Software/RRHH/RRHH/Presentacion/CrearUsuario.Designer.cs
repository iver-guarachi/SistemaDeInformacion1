namespace RRHH.Presentacion
{
    partial class CrearUsuario
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
            this.textBoxNuevoPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxSecreta = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarPassword = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSet_HastaDescuento = new RRHH.RecursosHumanosDataSet_HastaDescuento();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.empleadosNombreCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSetFinalVsitas2 = new RRHH.RecursosHumanosDataSetFinalVsitas2();
            this.label6 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter = new RRHH.RecursosHumanosDataSet_HastaDescuentoTableAdapters.UsuarioTableAdapter();
            this.rolTableAdapter = new RRHH.RecursosHumanosDataSet_HastaDescuentoTableAdapters.RolTableAdapter();
            this.empleados_NombreCompletoTableAdapter = new RRHH.RecursosHumanosDataSetFinalVsitas2TableAdapters.Empleados_NombreCompletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet_HastaDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetFinalVsitas2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNuevoPassword
            // 
            this.textBoxNuevoPassword.Location = new System.Drawing.Point(250, 104);
            this.textBoxNuevoPassword.Name = "textBoxNuevoPassword";
            this.textBoxNuevoPassword.PasswordChar = '*';
            this.textBoxNuevoPassword.Size = new System.Drawing.Size(215, 20);
            this.textBoxNuevoPassword.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Password Nuevo:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(373, 280);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 35;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(168, 280);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 34;
            this.buttonAceptar.Text = "Agregar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxSecreta
            // 
            this.textBoxSecreta.Location = new System.Drawing.Point(250, 158);
            this.textBoxSecreta.Name = "textBoxSecreta";
            this.textBoxSecreta.PasswordChar = '*';
            this.textBoxSecreta.Size = new System.Drawing.Size(215, 20);
            this.textBoxSecreta.TabIndex = 33;
            // 
            // textBoxConfirmarPassword
            // 
            this.textBoxConfirmarPassword.Location = new System.Drawing.Point(250, 130);
            this.textBoxConfirmarPassword.Name = "textBoxConfirmarPassword";
            this.textBoxConfirmarPassword.PasswordChar = '*';
            this.textBoxConfirmarPassword.Size = new System.Drawing.Size(215, 20);
            this.textBoxConfirmarPassword.TabIndex = 32;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(250, 78);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(215, 20);
            this.textBoxNombre.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Palabra Secreta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Confirmar Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Rol:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rolBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.recursosHumanosDataSet_HastaDescuento;
            // 
            // recursosHumanosDataSet_HastaDescuento
            // 
            this.recursosHumanosDataSet_HastaDescuento.DataSetName = "RecursosHumanosDataSet_HastaDescuento";
            this.recursosHumanosDataSet_HastaDescuento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(264, 280);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 44;
            this.buttonEliminar.Text = "Eiminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.usuarioBindingSource;
            this.listBox1.DisplayMember = "NombreUsuario";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 277);
            this.listBox1.TabIndex = 46;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.recursosHumanosDataSet_HastaDescuento;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.empleadosNombreCompletoBindingSource;
            this.comboBox2.DisplayMember = "NombreCompleto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(250, 215);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 21);
            this.comboBox2.TabIndex = 48;
            this.comboBox2.ValueMember = "Id_Empleado";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Empleado:";
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // empleados_NombreCompletoTableAdapter
            // 
            this.empleados_NombreCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 326);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNuevoPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxSecreta);
            this.Controls.Add(this.textBoxConfirmarPassword);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet_HastaDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosNombreCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSetFinalVsitas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNuevoPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxSecreta;
        private System.Windows.Forms.TextBox textBoxConfirmarPassword;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private RecursosHumanosDataSet_HastaDescuento recursosHumanosDataSet_HastaDescuento;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private RecursosHumanosDataSet_HastaDescuentoTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private RecursosHumanosDataSet_HastaDescuentoTableAdapters.RolTableAdapter rolTableAdapter;
        private RecursosHumanosDataSetFinalVsitas2 recursosHumanosDataSetFinalVsitas2;
        private System.Windows.Forms.BindingSource empleadosNombreCompletoBindingSource;
        private RecursosHumanosDataSetFinalVsitas2TableAdapters.Empleados_NombreCompletoTableAdapter empleados_NombreCompletoTableAdapter;        
    }
}