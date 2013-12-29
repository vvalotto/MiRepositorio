using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoLSP
{
    struct Punto { public double x, y;}

    public enum TipoForma { cuadrado, circulo };

    #region Clase Forma
    /// <summary>
    /// Esta clase no es abstracta, por lo tanto sus derivadas no implementan polimorfismo
    /// </summary>
    public class Forma
    {
        private TipoForma _tipo;

        public Forma(TipoForma t) 
        { 
            _tipo = t; 
        }

        public static void DibujarForma(Forma s)
        {
            //Esta función viola el principio de OCP. Si agregamos una figura para dibujar,
            //Se tiene que modificar el código de la función

        //    if (s._tipo == TipoForma.cuadrado)
        //        (s as Cuadrado).Dibujar();
        //    else if (s._tipo == TipoForma.circulo)
        //        (s as Circulo).Dibujar();
        }
            
    }
    #endregion

    #region Clase Circulo derivada de Forma
    /// <summary>
    /// La clase circulo solo hereda la variable miembros.
    /// La clase circulo no puede sustituirse por su padre, viola el LSP
    /// </summary>
    public class Circulo : Forma
    {
        private Punto _centro;
        private double _radio;
        public Circulo()
            : base(TipoForma.circulo)
        { }
        public void Dibujar()
        {
            /* draws the circle */
        }
    }
    #endregion

    #region Clase Cuadrado derivada de forma
    //public class Cuadrado : Forma
    //{
    //    private Punto _arribaIzq;
    //    private double _lado;
    //    public Cuadrado() : base(TipoForma.cuadrado) { }
    //    public void Dibujar()
    //    {
    //        /* draws the square */
    //    }
    //}
    #endregion


}
