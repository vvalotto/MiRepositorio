using System;
using CCP.EjemploSenial.Modelo;
using System.IO;

namespace CCP.EjemploSenial.Dominio
{
    /*Adquisidor de datos desde Archivo*/
    public class AdquisidorArchivo : Adquisidor
    {
        string _ubicacion;
        StreamReader _archivo;

        public string ubicacion
        {
            get {return _ubicacion;}
            set {_ubicacion = value;}
        }

        public AdquisidorArchivo(Senial senial)
            : base(senial)
        {
        }

        protected override decimal LeerDatoEntrada()
        {
            return 0;
        }

        public override void LeerSenial()
        {
            int _contador = 0;
            string _valor;
            decimal _dato;

            Console.WriteLine("Lectura de la Señal");
            try
            {
                this._archivo = new System.IO.StreamReader(_ubicacion);
                while ((_valor = _archivo.ReadLine()) != null)
                {
                    if (decimal.TryParse(_valor, out _dato))
                    {
                        this._senial.PonerValor(_dato);
                        _contador++;
                        Console.WriteLine("Datos Ingresados:{0}", _contador.ToString());
                    }
                    else
                    {
                        throw new System.InvalidOperationException("No son numeros");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
