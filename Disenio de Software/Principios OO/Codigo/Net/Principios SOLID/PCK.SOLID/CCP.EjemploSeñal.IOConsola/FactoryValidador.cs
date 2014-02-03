using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCP.EjemploSenial.IOConsola
{
    public class FactoryValidador
    {
        static public ValidadorConsola ObtenerValidador(string validador)
        {
            ValidadorConsola opValidador = null;

            if (validador == "Numero")
            {
                opValidador = new ValidadorNumero();
            }
            else if (validador == "Texto")
            {
                opValidador = new ValidadorTexto();
            }

            return opValidador;
        }
    }
}
