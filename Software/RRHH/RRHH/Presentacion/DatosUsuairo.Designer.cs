namespace RRHH
{
    partial class DatosUsuairo
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxSecreta = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarPassword = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAnteriorPassword = new System.Windows.Forms.TextBox();
            this.textBoxNuevoPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(328, 252);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(87, 252);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 22;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxSecreta
            // 
            this.textBoxSecreta.Location = new System.Drawing.Point(155, 149);
            this.textBoxSecreta.Name = "textBoxSecreta";
            this.textBoxSecreta.PasswordChar = '*';
            this.textBoxSecreta.Size = new System.Drawing.Size(215, 20);
            this.textBoxSecreta.TabIndex = 21;
            // 
            // textBoxConfirmarPassword
            // 
            this.textBoxConfirmarPassword.Location = new System.Drawing.Point(155, 121);
            this.textBoxConfirmarPassword.Name = "textBoxConfirmarPassword";
            this.textBoxConfirmarPassword.PasswordChar = '*';
            this.textBoxConfirmarPassword.Size = new System.Drawing.Size(215, 20);
            this.textBoxConfirmarPassword.TabIndex = 20;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(155, 38);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(215, 20);
            this.textBoxNombre.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Palabra Secreta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Confirmar Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password Anterior:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password Nuevo:";
            // 
            // textBoxAnteriorPassword
            // 
            this.textBoxAnteriorPassword.Location = new System.Drawing.Point(155, 67);
            this.textBoxAnteriorPassword.Name = "textBoxAnteriorPassword";
            this.textBoxAnteriorPassword.PasswordChar = '*';
            this.textBoxAnteriorPassword.Size = new System.Drawing.Size(215, 20);
            this.textBoxAnteriorPassword.TabIndex = 26;
            // 
            // textBoxNuevoPassword
            // 
            this.textBoxNuevoPassword.Location = new System.Drawing.Point(155, 95);
            this.textBoxNuevoPassword.Name = "textBoxNuevoPassword";
            this.textBoxNuevoPassword.PasswordChar = '*';
            this.textBoxNuevoPassword.Size = new System.Drawing.Size(215, 20);
            this.textBoxNuevoPassword.TabIndex = 27;
            // 
            // DatosUsuairo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 322);
            this.Controls.Add(this.textBoxNuevoPassword);
            this.Controls.Add(this.textBoxAnteriorPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxSecreta);
            this.Controls.Add(this.textBoxConfirmarPassword);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosUsuairo";
            this.Text = "DatosUsuairo";
            this.Load += new System.EventHandler(this.DatosUsuairo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxSecreta;
        private System.Windows.Forms.TextBox textBoxConfirmarPassword;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAnteriorPassword;
        private System.Windows.Forms.TextBox textBoxNuevoPassword;
    }
}