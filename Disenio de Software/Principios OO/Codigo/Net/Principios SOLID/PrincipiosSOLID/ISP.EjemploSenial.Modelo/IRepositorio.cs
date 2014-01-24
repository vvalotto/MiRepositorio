using System;
using ISP.EjemploSenial.Modelo;


namespace ISP.EjemploSenial.Repo
{
    interface IRepositorio
    {
        void Guardar(Senial senial);

        Senial Recuperar(int id);

        void Auditar(Senial senial);

        void Trazar(Senial senial);

    }
}
