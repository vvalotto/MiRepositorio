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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbXML = new System.Windows.Forms.RadioButton();
            this.rbTexto = new System.Windows.Forms.RadioButton();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDAdq = new System.Windows.Forms.TextBox();
            this.txtDescAdq = new System.Windows.Forms.TextBox();
            this.tctDescProc = new System.Windows.Forms.TextBox();
            this.txtIDProc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
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
            this.rbSenial2.Location = new System.Drawing.Point(61, 186);
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
            this.rbSenial1.Location = new System.Drawing.Point(61, 149);
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
            this.btnAdquirir.Location = new System.Drawing.Point(79, 243);
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
            this.panel2.Controls.Add(this.panel5);
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
            this.btnProcesar.Location = new System.Drawing.Point(74, 243);
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
            this.rbProc3.Location = new System.Drawing.Point(74, 206);
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
            this.rbProc2.Location = new System.Drawing.Point(74, 172);
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
            this.rbProc1.Location = new System.Drawing.Point(74, 136);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.rbXML);
            this.panel3.Controls.Add(this.rbTexto);
            this.panel3.Controls.Add(this.listBox3);
            this.panel3.Location = new System.Drawing.Point(545, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 601);
            this.panel3.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(88, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rbXML
            // 
            this.rbXML.AutoSize = true;
            this.rbXML.Location = new System.Drawing.Point(63, 206);
            this.rbXML.Name = "rbXML";
            this.rbXML.Size = new System.Drawing.Size(104, 17);
            this.rbXML.TabIndex = 5;
            this.rbXML.TabStop = true;
            this.rbXML.Text = "Guardar En XML";
            this.rbXML.UseVisualStyleBackColor = true;
            this.rbXML.CheckedChanged += new System.EventHandler(this.rbXML_CheckedChanged);
            // 
            // rbTexto
            // 
            this.rbTexto.AutoSize = true;
            this.rbTexto.Location = new System.Drawing.Point(63, 172);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(108, 17);
            this.rbTexto.TabIndex = 4;
            this.rbTexto.TabStop = true;
            this.rbTexto.Text = "Guardar en Texto";
            this.rbTexto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbTexto.UseVisualStyleBackColor = true;
            this.rbTexto.CheckedChanged += new System.EventHandler(this.rbTexto_CheckedChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(25, 292);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(196, 264);
            this.listBox3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.txtDescAdq);
            this.panel4.Controls.Add(this.txtIDAdq);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(21, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 113);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.tctDescProc);
            this.panel5.Controls.Add(this.txtIDProc);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(25, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 113);
            this.panel5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Señal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // txtIDAdq
            // 
            this.txtIDAdq.Location = new System.Drawing.Point(87, 20);
            this.txtIDAdq.Name = "txtIDAdq";
            this.txtIDAdq.Size = new System.Drawing.Size(100, 20);
            this.txtIDAdq.TabIndex = 2;
            // 
            // txtDescAdq
            // 
            this.txtDescAdq.Location = new System.Drawing.Point(87, 62);
            this.txtDescAdq.Name = "txtDescAdq";
            this.txtDescAdq.Size = new System.Drawing.Size(100, 20);
            this.txtDescAdq.TabIndex = 3;
            // 
            // tctDescProc
            // 
            this.tctDescProc.Location = new System.Drawing.Point(92, 67);
            this.tctDescProc.Name = "tctDescProc";
            this.tctDescProc.Size = new System.Drawing.Size(100, 20);
            this.tctDescProc.TabIndex = 7;
            // 
            // txtIDProc
            // 
            this.txtIDProc.Location = new System.Drawing.Point(92, 25);
            this.txtIDProc.Name = "txtIDProc";
            this.txtIDProc.Size = new System.Drawing.Size(100, 20);
            this.txtIDProc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Señal";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Controls.Add(this.txtUbicacion);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(25, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 113);
            this.panel6.TabIndex = 9;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(96, 22);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 20);
            this.txtUbicacion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ubicacion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SOLID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbXML;
        private System.Windows.Forms.RadioButton rbTexto;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDescAdq;
        private System.Windows.Forms.TextBox txtIDAdq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tctDescProc;
        private System.Windows.Forms.TextBox txtIDProc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label5;
    }
}

