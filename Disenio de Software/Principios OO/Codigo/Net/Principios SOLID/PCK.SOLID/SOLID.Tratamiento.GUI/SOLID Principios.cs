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
        
        Adquisidor adquisidor;
        IProcesador procesador;
        Senial senialAdquirida;
        Senial senialProcesada;

        public Form1()
        {
            InitializeComponent();
            senialAdquirida = FactorySenial.ObtenerSenial("Pila", 10);
            senialProcesada = FactorySenial.ObtenerSenial("Cola", 10);
            
        }


        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            adquisidor.LeerSenial();

            for (int i = 0; i < senialAdquirida.CantidadValores(); i++)
            {
                listBox1.Items.Add(senialAdquirida.ObtenerValor(i));
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
 
            listBox1.Items.Add(senialAdquirida.descripcion);

            for (int i = 0; i < senialAdquirida.CantidadValores(); i++)
            {
                listBox1.Items.Add(senialAdquirida.ObtenerValor(i));
            }

        }

        private void rbSenial2_CheckedChanged(object sender, EventArgs e)
        {
            adquisidor = FactoryAdquisidor.ObtenerAdquisidor("Archivo", senialAdquirida);
        }

        private void rbSenial1_CheckedChanged(object sender, EventArgs e)
        {
            adquisidor = FactoryAdquisidor.ObtenerAdquisidor("Senoidal", senialAdquirida);
        }


        private void btnProcesar_Click(object sender, EventArgs e)
        {

            listBox2.Items.Add(senialProcesada.descripcion);

            for (int i = 0; i < senialProcesada.CantidadValores(); i++)
            {
                listBox2.Items.Add(senialProcesada.ObtenerValor(i));
            }
        }

		private void rbProc1_CheckedChanged(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
			senialProcesada.Limpiar();
			procesador = FactoryProcesador.ObtenerProcesador("Simple");
			procesador.Procesar(senialAdquirida, senialProcesada);

		}

        private void rbProc2_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            senialProcesada.Limpiar();
            
            procesador = FactoryProcesador.ObtenerProcesador("Umbral");
            procesador.Procesar(senialAdquirida, senialProcesada);
            ;
        }

        private void rbProc3_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            senialProcesada.Limpiar();
            procesador = FactoryProcesador.ObtenerProcesador("Diferencial");
            procesador.Procesar(senialAdquirida, senialProcesada);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
