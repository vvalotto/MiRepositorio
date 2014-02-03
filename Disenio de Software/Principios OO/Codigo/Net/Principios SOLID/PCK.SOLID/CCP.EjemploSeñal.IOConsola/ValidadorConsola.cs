using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCP.EjemploSenial.IOConsola
{

    public abstract class ValidadorConsola
    {
        string _patron;

        public string Patron
        {
            get { return _patron; }
            set { _patron = value; }
        }

        int _largo;

        public int Largo
        {
            get { return _largo; }
            set { _largo = value; }
        }

        protected Dictionary<string, string> _mensajesError = new Dictionary<string,string>();

        public abstract void ConfigurarMensajeError();

        public abstract string Validar(string entrada);
    }
}
