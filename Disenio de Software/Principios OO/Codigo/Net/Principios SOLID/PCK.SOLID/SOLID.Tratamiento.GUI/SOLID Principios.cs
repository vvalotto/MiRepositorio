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
using DIP.EjemploSenial.Procesador;

namespace SOLID.Tratamiento.GUI
{
    public partial class Form1 : Form
    {
        Senial senial;
        Adquisidor adquisidor;
        GestorAdquisidor gAdquisidor;
        GestorProcesador gProcesador = null;
        Senial senialProcesada;

        public Form1()
        {
            InitializeComponent();
            gAdquisidor = new GestorAdquisidor();
        }


        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            
            senial = new SenialBasica();
            gAdquisidor.Adquirir();
            
            senial = (gAdquisidor.Obtener());
            listBox1.Items.Add(senial.descripcion);

            for (int i = 0; i < senial.CantidadValores(); i++)
            {
                listBox1.Items.Add(senial.ObtenerValor(i));
            }
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

        }

        private void rbSenial1_CheckedChanged(object sender, EventArgs e)
        {
            AdquisidorSenoidal adquisidor = new AdquisidorSenoidal(new SenialPila(15));
            gAdquisidor.adquisidor = adquisidor;
        }

        private void rbProc1_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            this.senialProcesada = new SenialBasica();

            this.gProcesador = new GestorProcesador(new ProcesadorSimple());
            this.gProcesador.Procesar(gAdquisidor.Obtener(), this.senialProcesada);
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            senial = new SenialBasica();
            senial = this.senialProcesada;
            listBox2.Items.Add(senial.descripcion);

            for (int i = 0; i < senial.CantidadValores(); i++)
            {
                listBox2.Items.Add(senial.ObtenerValor(i));
            }
        }

        private void rbProc2_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            this.senialProcesada = new SenialBasica();

            this.gProcesador = new GestorProcesador(new ProcesadorConUmbral());
            this.gProcesador.Procesar(gAdquisidor.Obtener(), this.senialProcesada);
        }

        private void rbProc3_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            this.senialProcesada = new SenialBasica();

            this.gProcesador = new GestorProcesador(new ProcesadorDiferencial());
            this.gProcesador.Procesar(gAdquisidor.Obtener(), this.senialProcesada);
        }

    }
}
