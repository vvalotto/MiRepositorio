using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.Consola
{
	public interface IProcesador
    {
		void Procesar(Senial senialAdquirida, Senial senialProcesada);
    }

}
