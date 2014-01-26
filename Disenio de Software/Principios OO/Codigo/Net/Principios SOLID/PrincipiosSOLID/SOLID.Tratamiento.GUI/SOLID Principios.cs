using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIP.EjemploSenial.Modelo;
using DIP.EjemploSenial.Adquisidor;
using DIP.EjemploSenial.Utils;

namespace SOLID.Tratamiento.GUI
{
    public partial class Form1 : Form
    {
        Senial senial;
        Adquisidor adquisidor;
        GestorAdquisidor gAdquisidor;

        public Form1()
        {
            InitializeComponent();
            gAdquisidor = new GestorAdquisidor();
        }

        public void Senial1_Click(object sender, EventArgs e)
        {
            adquisidor = new AdquisidorSimple(new SenialPila(15));
            gAdquisidor.adquisidor = adquisidor;
        }

        public void Senial2_Click(object sender, EventArgs e)
        {
            /*adquisidor = new AdquisidorArchivo(new SenialPila(15));
            gAdquisidor.adquisidor = adquisidor;*/
            MessageBox.Show("Click");
        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            gAdquisidor.Adquirir();
            MessageBox.Show("Seña Adquirida");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            senial = new SenialBasica();
            senial = (gAdquisidor.Obtener());
            listBox1.Items.Add(senial.descripcion);

            for (int i = 0; i < senial.CantidadValores(); i++)
            {
                listBox1.Items.Add(senial.ObtenerValor(i));
            }

        }

        private void rbSenial2_CheckedChanged(object sender, EventArgs e)
        {
            AdquisidorArchivo ad = new AdquisidorArchivo(new SenialPila(15));
            ad.ubicacion = "c:\\Temp\\Datos.txt";
            adquisidor = ad;
            
            gAdquisidor.adquisidor = adquisidor;
            MessageBox.Show("Click");
        }
    }
}
