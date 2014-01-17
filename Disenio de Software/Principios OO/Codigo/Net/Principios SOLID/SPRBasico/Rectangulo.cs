using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SPRBasico
{
    class Rectangulo
    {
        public decimal CalcularArea(int ancho, int altura)
        {
            return ancho * altura;
        }

        public Rectangle DibujarArea(int ancho, int altura)
        {
            Rectangle miRect = new Rectangle();

            miRect.Height = altura;
            miRect.Width = ancho;
            decimal area = this.CalcularArea (miRect.Width, miRect.Height);
                        
            return miRect;
        }
    }
}
