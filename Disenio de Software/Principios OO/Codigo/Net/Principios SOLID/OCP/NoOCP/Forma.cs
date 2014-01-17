using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoOCP
{
    public enum TipoForma
    {
        TipoCuadrado,
        TipoCirculo
    }

    public class Forma
    {
        public int _tipo;

    }

    public class Cuadrado : Forma
    {
        public Cuadrado()
        {
            _tipo = 2;
        }
    }

    public class Circulo : Forma
    {
        public Circulo()
        {
            _tipo = 1;
        }
    }

 }
