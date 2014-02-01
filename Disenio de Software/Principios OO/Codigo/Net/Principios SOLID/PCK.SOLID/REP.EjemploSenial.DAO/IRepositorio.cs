using System;
using REP.EjemploSenial.Modelo;


namespace REP.EjemploSenial.DAO

{
	public interface IRepositorio
    {
        void Guardar(Senial senial);

		Senial Recuperar(object id);

		void Auditar(Senial senial, string programa);

		void Trazar(Senial senial, string mensaje);

    }
}
