using System;
using ISP.EjemploSenial.Modelo;


namespace ISP.EjemploSenial.DAO

{
    interface IRepositorio
    {
        void Guardar(Senial senial);

        Senial Recuperar(int id);

		void Auditar(Senial senial, string programa);

		void Trazar(Senial senial, string mensaje);

    }
}
