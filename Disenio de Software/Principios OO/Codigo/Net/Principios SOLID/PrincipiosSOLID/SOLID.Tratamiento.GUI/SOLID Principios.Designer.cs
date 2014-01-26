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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdquirir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSenial2);
            this.panel1.Controls.Add(this.rbSenial1);
            this.panel1.Controls.Add(this.btnMostrar);
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
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(83, 562);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 259);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 264);
            this.listBox1.TabIndex = 3;
            // 
            // btnAdquirir
            // 
            this.btnAdquirir.Location = new System.Drawing.Point(79, 115);
            this.btnAdquirir.Name = "btnAdquirir";
            this.btnAdquirir.Size = new System.Drawing.Size(75, 23);
            this.btnAdquirir.TabIndex = 2;
            this.btnAdquirir.Text = "Adquirir";
            this.btnAdquirir.UseVisualStyleBackColor = true;
            this.btnAdquirir.Click += new System.EventHandler(this.btnAdquirir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 655);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SOLID";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdquirir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.RadioButton rbSenial2;
        private System.Windows.Forms.RadioButton rbSenial1;
    }
}

