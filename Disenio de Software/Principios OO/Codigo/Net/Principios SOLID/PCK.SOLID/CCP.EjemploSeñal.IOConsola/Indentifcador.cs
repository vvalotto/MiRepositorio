using System;
using CCP.EjemploSenial.Modelo;

namespace CCP.EjemploSenial.IOConsola
{
	public class Identificador
	{

		public void Ingresar(Senial senial, string titulo)
		{

            string o = "N";

            while (o != "S")
            {
                Console.Clear();
                Console.WriteLine(titulo);

                IngresarID();
                IngresarDescripcion();

                Console.Write("Es correcto (S/N)?");
                o = Console.ReadLine().ToUpper();
            }
		}

       string IngresarID()
        {

            string entrada = ""; ;
            string _resulValidacion;
            bool _errorIngreso;
            ValidadorConsola _validadorID;

            _validadorID = FactoryValidador.ObtenerValidador("Numero");
            _validadorID.ConfigurarMensajeError();
            _validadorID.Patron = "[0-9]";
            _validadorID.Largo = 3;

            _errorIngreso = true;
            while (_errorIngreso)
                {
                    Console.Write("Identificador de la Señal (numero):");
                    entrada = Console.ReadLine();
                    _resulValidacion = _validadorID.Validar(entrada);

                    if (_resulValidacion != "OK")
                    {
                        Console.WriteLine(_resulValidacion);
                    }
                    else
                    {
                        _errorIngreso = false;
                    }
                }
            return entrada;
		}

       string IngresarDescripcion()
       {
           string entrada ="";
           string _resulValidacion;
           bool _errorIngreso;
           ValidadorConsola _validadorDesc;

           _validadorDesc = FactoryValidador.ObtenerValidador("Texto");
           _validadorDesc.ConfigurarMensajeError();
           _validadorDesc.Patron = "[A-Za-z0-9_.]";
           _validadorDesc.Largo = 200;

           _errorIngreso = true;
           while (_errorIngreso)
           {
               Console.Write("Descripcion de identificacion:");
               entrada = Console.ReadLine();
               _resulValidacion = _validadorDesc.Validar(entrada);

               if (_resulValidacion != "OK")
               {
                   Console.WriteLine(_resulValidacion);
               }
               else
               {
                   _errorIngreso = false;
               }
           }
           return entrada;
       }
	}
}
