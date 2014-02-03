using System;
using CCP.EjemploSenial.Modelo;
using CCP.EjemploSenial.IOConsola;

namespace CCP.EjemploSenial.Dominio
{
    /*Adquisidor de datos desde el teclado*/
    public class AdquisidorSimple : Adquisidor
    {

        public AdquisidorSimple(Senial senial)
            : base(senial)
        {
        }

        protected override decimal LeerDatoEntrada()
        {
            string _datoEnt = "0";
      /*
            _datoEnt = Console.ReadLine();
            while (!decimal.TryParse(_datoEnt, out _dato))
            {
                Console.WriteLine("Dato mal ingresado, presione una tecla");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Ingresar Dato:");
                _datoEnt = Console.ReadLine();

            }
             */
            string _resulValidacion;
            bool _errorIngreso;
            ValidadorConsola _validadorDato;

            _validadorDato = FactoryValidador.ObtenerValidador("Numero");
            _validadorDato.ConfigurarMensajeError();
            _validadorDato.Patron = "[0-9]";
            _validadorDato.Largo = 6;

            _errorIngreso = true;
            while (_errorIngreso)
            {
                Console.Write("Ingresar Dato:");
                _datoEnt = Console.ReadLine();
                _resulValidacion = _validadorDato.Validar(_datoEnt);

                if (_resulValidacion != "OK")
                {
                    Console.WriteLine(_resulValidacion);
                }
                else
                {
                    _errorIngreso = false;
                }
            }
            
            return Convert.ToDecimal(_datoEnt);

        }

        public override void LeerSenial()
        {
			int _nroMuestra = 5;

            Console.WriteLine("Lectura de la Señal");
            for (int i = 1; i <= _nroMuestra; i++)
            {
                this._senial.PonerValor(LeerDatoEntrada());
                Console.WriteLine("Datos Ingresados:{0}", i.ToString());
            }

        }
    }

}
