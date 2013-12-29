using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EjemploFactoria1;

namespace EjemploFactoria1
{
    public partial class Form1 : Form
    {
        NameFactory nameFact = new NameFactory();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, System.EventArgs e) 
        {
            Namer nm = nameFact.getName(txtNombre.Text);
            lblNombre.Text = nm.getFrname();
            lblApellido.Text = nm.getLname();
        }
        
    }
}
