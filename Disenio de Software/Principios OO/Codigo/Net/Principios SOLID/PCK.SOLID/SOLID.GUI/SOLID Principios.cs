using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REP.EjemploSenial.Modelo;
using REP.EjemploSenial.Adquisidor;
using REP.EjemploSenial.Utils;
using REP.EjemploSenial.Procesador;
using REP.EjemploSenial.DAO;

namespace SOLID.Tratamiento.GUI
{
    public partial class Form1 : Form
    {
        
        Adquisidor adquisidor;
        IProcesador procesador;
        Senial senialAdquirida;
        Senial senialProcesada;
        IRepositorio repositorio;

        public Form1()
        {
            InitializeComponent();
            senialAdquirida = FactorySenial.ObtenerSenial("Pila", 10);
            senialProcesada = FactorySenial.ObtenerSenial("Cola", 10);
            
        }


        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            
            if (adquisidor == null) {
                MessageBox.Show("No se ha seleccionado un adquisidor","Atención");
            }
            else if ((txtDescAdq.Text.Length == 0) && (txtIDAdq.Text.Length == 0)){
                MessageBox.Show("No se la ingresado identificacion","Atención");
            }
            else{
                senialAdquirida.descripcion = txtDescAdq.Text;
                senialAdquirida.Id = Convert.ToInt16(txtIDAdq.Text);
                adquisidor.LeerSenial();

                for (int i = 0; i < senialAdquirida.CantidadValores(); i++)
                {
                    listBox1.Items.Add(senialAdquirida.ObtenerValor(i));
                }
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

            if (senialAdquirida == null) {
                MessageBox.Show("No se hay seña adquirida","Atención");
            }
            else if (procesador == null) {
                MessageBox.Show("No se ha seleccionado un procesador","Atención");
            }
            else if ((tctDescProc.Text.Length == 0) && (txtIDProc.Text.Length == 0))
            {
                MessageBox.Show("No se la ingresado identificacion", "Atención");
            }
            else
            {
                listBox2.Items.Add(senialProcesada.descripcion);

                for (int i = 0; i < senialProcesada.CantidadValores(); i++)
                {
                    listBox2.Items.Add(senialProcesada.ObtenerValor(i));
                }
            }
        }

		private void rbProc1_CheckedChanged(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
			senialProcesada.Limpiar();
            senialProcesada.descripcion = txtDescAdq.Text;
            senialProcesada.Id = Convert.ToInt16(txtIDAdq.Text);
			procesador = FactoryProcesador.ObtenerProcesador("Simple");
			procesador.Procesar(senialAdquirida, senialProcesada);

		}

        private void rbProc2_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            senialProcesada.Limpiar();
            senialProcesada.descripcion = txtDescAdq.Text;
            senialProcesada.Id = Convert.ToInt16(txtIDAdq.Text);
            procesador = FactoryProcesador.ObtenerProcesador("Umbral");
            procesador.Procesar(senialAdquirida, senialProcesada);
            
        }

        private void rbProc3_CheckedChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            senialProcesada.Limpiar();
            senialProcesada.descripcion = txtDescAdq.Text;
            senialProcesada.Id = Convert.ToInt16(txtIDAdq.Text);
            procesador = FactoryProcesador.ObtenerProcesador("Diferencial");
            procesador.Procesar(senialAdquirida, senialProcesada);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbXML_CheckedChanged(object sender, EventArgs e)
        {
            repositorio = FactoryDAO.ObtenerRepositorio("XML", txtUbicacion.Text);
        }

        private void rbTexto_CheckedChanged(object sender, EventArgs e)
        {
            repositorio = FactoryDAO.ObtenerRepositorio("Texto", txtUbicacion.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Senial senTemp;
            repositorio.Guardar(senialProcesada);
            listBox3.Items.Clear();
            listBox3.Items.Add("Se guardo la siguiente señal");
            senTemp = repositorio.Recuperar(senialProcesada.Id);

            listBox3.Items.Add(senTemp.Id);
            listBox3.Items.Add(senTemp.descripcion);

            for (int i = 0; i < senTemp.CantidadValores(); i++)
            {
                listBox3.Items.Add(senTemp.ObtenerValor(i));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
