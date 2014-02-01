using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using REP.EjemploSenial.Modelo;

namespace REP.EjemploSenial.Adquisidor
{
    public class AdquisidorSenoidal:Adquisidor
    {
        int _largo = 20;
        double _valor = 0;

        public AdquisidorSenoidal(Senial senial):
            base(senial)
        {
        }
        
        protected override decimal LeerDatoEntrada()
        {
            
            return Convert.ToDecimal(Math.Sin(_valor) * 10);

        }

        public override void LeerSenial()
        {

            Console.WriteLine("Lectura de la Señal");
            for (int i = 1; i <= _largo; i++)
            {
                this._valor = ((double)i / (double)this._largo) * 2 * 3.14;
                this._senial.PonerValor(LeerDatoEntrada());
                Console.WriteLine("Datos Ingresados:{0}", i.ToString());
            }

        }
    }
}
