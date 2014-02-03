using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCP.EjemploSenial.Modelo;

namespace CCP.EjemploSenial.Dominio
{
	public interface IProcesador
    {
		void Procesar(Senial senialAdquirida, Senial senialProcesada);
    }

}
