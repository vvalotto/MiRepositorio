using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoLSP
{
    public class Vehiculo
    {

        protected string _marca;
        protected string _modelo;
        protected int _cilindrada;

        public string Marca { get { return _marca; } }
        public string Modelo { get{ return _modelo; }  }
        public int Cilindrada { get{ return _cilindrada; } }

    }

    public class Ciclomotor : Vehiculo
    {
        public string ObtenerNumLicencia()
        {
            // Devuelve número de licencia
            Console.WriteLine("Obtiene numero de licencia");
            return "Licencia";

        }

        public Ciclomotor(string marca, string modelo, int cilindrada)
        {
            base._marca = marca;
            base._modelo = modelo;
            base._cilindrada = cilindrada;
        }
    }

    public class Coche : Vehiculo
    {
        public string ObtenerMatricula()
        {
            Console.WriteLine("Obtiene Matrícula");
            return "Matricula";
        }
        
        public Coche    (string marca, string modelo, int cilindrada)
        {
            base._marca = marca;
            base._modelo = modelo;
            base._cilindrada = cilindrada;
        }
    }

    
    public class Impuestos
    {
        public void CalcularImpuesto(Vehiculo vehiculo)
        {
            
            //Con el problema de violación al LSP
            string matricula = ((Coche)vehiculo).ObtenerMatricula();
            ServicioCalculoImpuestos(matricula, vehiculo.Cilindrada);

            //Solución, pero con violación al OCP
			//string matricula = string.Empty;
			//if (vehiculo.GetType().Name == "Coche")
			//    matricula = ((Coche)vehiculo).ObtenerMatricula();
			//else if (vehiculo.GetType().Name == "Ciclomotor")
			//    matricula = ((Ciclomotor)vehiculo).ObtenerNumLicencia();
			//ServicioCalculoImpuestos(matricula, vehiculo.Cilindrada);
        }


        void ServicioCalculoImpuestos(string m, int cil)
        {
            Console.WriteLine("Servicio de Cálculo");
        }

    }
}
