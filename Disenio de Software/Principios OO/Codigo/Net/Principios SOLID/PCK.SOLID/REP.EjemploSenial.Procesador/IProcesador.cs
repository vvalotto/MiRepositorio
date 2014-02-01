using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using REP.EjemploSenial.Modelo;

namespace REP.EjemploSenial.Procesador
{
	public interface IProcesador
    {
		void Procesar(Senial senialAdquirida, Senial senialProcesada);
    }

}
