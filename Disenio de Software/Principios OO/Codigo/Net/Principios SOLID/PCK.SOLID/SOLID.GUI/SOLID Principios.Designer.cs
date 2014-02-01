namespace SOLID.Tratamiento.GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSenial2 = new System.Windows.Forms.RadioButton();
            this.rbSenial1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdquirir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.rbProc3 = new System.Windows.Forms.RadioButton();
            this.rbProc2 = new System.Windows.Forms.RadioButton();
            this.rbProc1 = new System.Windows.Forms.RadioButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbSenial2);
            this.panel1.Controls.Add(this.rbSenial1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnAdquirir);
            this.panel1.Location = new System.Drawing.Point(31, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 601);
            this.panel1.TabIndex = 1;
            // 
            // rbSenial2
            // 
            this.rbSenial2.AutoSize = true;
            this.rbSenial2.Location = new System.Drawing.Point(65, 61);
            this.rbSenial2.Name = "rbSenial2";
            this.rbSenial2.Size = new System.Drawing.Size(93, 17);
            this.rbSenial2.TabIndex = 6;
            this.rbSenial2.TabStop = true;
            this.rbSenial2.Text = "Senial Archivo";
            this.rbSenial2.UseVisualStyleBackColor = true;
            this.rbSenial2.CheckedChanged += new System.EventHandler(this.rbSenial2_CheckedChanged);
            // 
            // rbSenial1
            // 
            this.rbSenial1.AutoSize = true;
            this.rbSenial1.Location = new System.Drawing.Point(65, 25);
            this.rbSenial1.Name = "rbSenial1";
            this.rbSenial1.Size = new System.Drawing.Size(89, 17);
            this.rbSenial1.TabIndex = 5;
            this.rbSenial1.TabStop = true;
            this.rbSenial1.Text = "Senial Basica";
            this.rbSenial1.UseVisualStyleBackColor = true;
            this.rbSenial1.CheckedChanged += new System.EventHandler(this.rbSenial1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 292);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 264);
            this.listBox1.TabIndex = 3;
            // 
            // btnAdquirir
            // 
            this.btnAdquirir.Location = new System.Drawing.Point(79, 169);
            this.btnAdquirir.Name = "btnAdquirir";
            this.btnAdquirir.Size = new System.Drawing.Size(75, 23);
            this.btnAdquirir.TabIndex = 2;
            this.btnAdquirir.Text = "Adquirir";
            this.btnAdquirir.UseVisualStyleBackColor = true;
            this.btnAdquirir.Click += new System.EventHandler(this.btnAdquirir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnProcesar);
            this.panel2.Controls.Add(this.rbProc3);
            this.panel2.Controls.Add(this.rbProc2);
            this.panel2.Controls.Add(this.rbProc1);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Location = new System.Drawing.Point(288, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 601);
            this.panel2.TabIndex = 2;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(72, 169);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // rbProc3
            // 
            this.rbProc3.AutoSize = true;
            this.rbProc3.Location = new System.Drawing.Point(59, 101);
            this.rbProc3.Name = "rbProc3";
            this.rbProc3.Size = new System.Drawing.Size(75, 17);
            this.rbProc3.TabIndex = 6;
            this.rbProc3.TabStop = true;
            this.rbProc3.Text = "Diferencial";
            this.rbProc3.UseVisualStyleBackColor = true;
            this.rbProc3.CheckedChanged += new System.EventHandler(this.rbProc3_CheckedChanged);
            // 
            // rbProc2
            // 
            this.rbProc2.AutoSize = true;
            this.rbProc2.Location = new System.Drawing.Point(59, 61);
            this.rbProc2.Name = "rbProc2";
            this.rbProc2.Size = new System.Drawing.Size(58, 17);
            this.rbProc2.TabIndex = 5;
            this.rbProc2.TabStop = true;
            this.rbProc2.Text = "Umbral";
            this.rbProc2.UseVisualStyleBackColor = true;
            this.rbProc2.CheckedChanged += new System.EventHandler(this.rbProc2_CheckedChanged);
            // 
            // rbProc1
            // 
            this.rbProc1.AutoSize = true;
            this.rbProc1.Location = new System.Drawing.Point(59, 25);
            this.rbProc1.Name = "rbProc1";
            this.rbProc1.Size = new System.Drawing.Size(129, 17);
            this.rbProc1.TabIndex = 4;
            this.rbProc1.TabStop = true;
            this.rbProc1.Text = "Procesamiento Simple";
            this.rbProc1.UseVisualStyleBackColor = true;
            this.rbProc1.CheckedChanged += new System.EventHandler(this.rbProc1_CheckedChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(25, 292);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(196, 264);
            this.listBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SOLID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdquirir;
        private System.Windows.Forms.RadioButton rbSenial2;
        private System.Windows.Forms.RadioButton rbSenial1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.RadioButton rbProc3;
        private System.Windows.Forms.RadioButton rbProc2;
        private System.Windows.Forms.RadioButton rbProc1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

