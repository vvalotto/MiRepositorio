using System;
using System.Collections;
using System.Reflection;

namespace ISP.EjemploSenial.Modelo
{
	
    public interface ISenial
    {
		void PonerValor (decimal valor);

        int CantidadValores();

        decimal SacarValor ();

        decimal SacarValor(int indice);

    }        
 

}

