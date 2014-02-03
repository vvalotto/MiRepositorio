using System;
using CCP.EjemploSenial.Modelo;


namespace CCP.EjemploSenial.Datos

{
	public interface IRepositorio
    {
        void Guardar(Senial senial);

		Senial Recuperar(object id);

		void Auditar(Senial senial, string programa);

		void Trazar(Senial senial, string mensaje);

    }
}
