using System;
using System.Collections;
using System.Reflection;

namespace SOLID.Consola
{
	
    public interface ISenial
    {
		void PonerValor (decimal valor);

        int CantidadValores();

        decimal SacarValor ();

        decimal SacarValor(int indice);

    }        
 

}

