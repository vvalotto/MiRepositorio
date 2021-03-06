﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCP.EjemploSenial.Modelo;

namespace CCP.EjemploSenial.Datos
{
    public class FactoryDAO
    {
        static public IRepositorio ObtenerRepositorio(string sRepositorio, string ubicacion)
        {
            IRepositorio opRepositorio = null;

            if (sRepositorio == "Texto")
            {
                opRepositorio = new RepositorioArchivo(ubicacion);
            }
            else if (sRepositorio == "XML")
            {
                opRepositorio = new RepositorioXML(ubicacion);
            }

            return opRepositorio;
        }

    }
}
