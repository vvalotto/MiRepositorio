using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DIP.EjemploSenial.Modelo;

namespace DIP.EjemploSenial.Procesador
{
	public interface IProcesador
    {
		void Procesar(Senial senialAdquirida, Senial senialProcesada);
    }

}
