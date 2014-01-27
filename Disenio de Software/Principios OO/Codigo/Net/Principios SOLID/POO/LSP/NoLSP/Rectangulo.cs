using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoLSP
{ 

    public class Rectangulo
    {
        private Punto _arribaIzq;
        private double _base;
        private double _altura;

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }
        public double Alto
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public Rectangulo()
        {
        }

        public Rectangulo(double x, double y)
        {
            _arribaIzq.x = x;
            _arribaIzq.y = y;

        }
    }

    public class Cuadrado : Rectangulo
    {
        
        //public Cuadrado (double x, double y)
        //{
        //    _arribaIzq.x = x;
        //    _arribaIzq.y = y;
        //}

        public new double Alto
        {
            set
            {
                base.Alto = value;
                base.Base = value;
            }
            get { return base.Alto; }
        }

        public new double Base
        {
            set
            {
                base.Alto = value;
                base.Base = value;
            }

            get { return base.Base; }
        }
    }
    
}
