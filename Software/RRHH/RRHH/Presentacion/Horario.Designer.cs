namespace RRHH.Presentacion
{
    partial class Horario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.numericUpDownHoraEntrada = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinEntrada = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHoraSalida = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinSalida = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Salida:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.comboBoxNombre.Location = new System.Drawing.Point(197, 48);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(139, 21);
            this.comboBoxNombre.TabIndex = 10;
            this.comboBoxNombre.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombre_SelectedIndexChanged);
            // 
            // numericUpDownHoraEntrada
            // 
            this.numericUpDownHoraEntrada.Location = new System.Drawing.Point(197, 86);
            this.numericUpDownHoraEntrada.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHoraEntrada.Name = "numericUpDownHoraEntrada";
            this.numericUpDownHoraEntrada.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownHoraEntrada.TabIndex = 11;
            // 
            // numericUpDownMinEntrada
            // 
            this.numericUpDownMinEntrada.Location = new System.Drawing.Point(246, 86);
            this.numericUpDownMinEntrada.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinEntrada.Name = "numericUpDownMinEntrada";
            this.numericUpDownMinEntrada.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMinEntrada.TabIndex = 12;
            // 
            // numericUpDownHoraSalida
            // 
            this.numericUpDownHoraSalida.Location = new System.Drawing.Point(197, 123);
            this.numericUpDownHoraSalida.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHoraSalida.Name = "numericUpDownHoraSalida";
            this.numericUpDownHoraSalida.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownHoraSalida.TabIndex = 13;
            // 
            // numericUpDownMinSalida
            // 
            this.numericUpDownMinSalida.Location = new System.Drawing.Point(246, 123);
            this.numericUpDownMinSalida.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinSalida.Name = "numericUpDownMinSalida";
            this.numericUpDownMinSalida.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMinSalida.TabIndex = 14;
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 242);
            this.Controls.Add(this.numericUpDownMinSalida);
            this.Controls.Add(this.numericUpDownHoraSalida);
            this.Controls.Add(this.numericUpDownMinEntrada);
            this.Controls.Add(this.numericUpDownHoraEntrada);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Horario";
            this.Text = "RegsitroHorario";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoraSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.NumericUpDown numericUpDownHoraEntrada;
        private System.Windows.Forms.NumericUpDown numericUpDownMinEntrada;
        private System.Windows.Forms.NumericUpDown numericUpDownHoraSalida;
        private System.Windows.Forms.NumericUpDown numericUpDownMinSalida;
    }
}