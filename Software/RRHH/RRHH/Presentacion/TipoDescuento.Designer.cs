namespace RRHH.Presentacion
{
    partial class TipoDescuento
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.recursosHumanosDataSet_HastaDescuento = new RRHH.RecursosHumanosDataSet_HastaDescuento();
            this.tipoDescuentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDescuentoTableAdapter = new RRHH.RecursosHumanosDataSet_HastaDescuentoTableAdapters.TipoDescuentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet_HastaDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDescuentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Eiminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tipoDescuentoBindingSource;
            this.listBox1.DisplayMember = "Descripcion";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // recursosHumanosDataSet_HastaDescuento
            // 
            this.recursosHumanosDataSet_HastaDescuento.DataSetName = "RecursosHumanosDataSet_HastaDescuento";
            this.recursosHumanosDataSet_HastaDescuento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDescuentoBindingSource
            // 
            this.tipoDescuentoBindingSource.DataMember = "TipoDescuento";
            this.tipoDescuentoBindingSource.DataSource = this.recursosHumanosDataSet_HastaDescuento;
            // 
            // tipoDescuentoTableAdapter
            // 
            this.tipoDescuentoTableAdapter.ClearBeforeFill = true;
            // 
            // TipoDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 247);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Name = "TipoDescuento";
            this.Text = "TipoDescuento";
            this.Load += new System.EventHandler(this.TipoDescuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet_HastaDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDescuentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private RecursosHumanosDataSet_HastaDescuento recursosHumanosDataSet_HastaDescuento;
        private System.Windows.Forms.BindingSource tipoDescuentoBindingSource;
        private RecursosHumanosDataSet_HastaDescuentoTableAdapters.TipoDescuentoTableAdapter tipoDescuentoTableAdapter;
    }
}