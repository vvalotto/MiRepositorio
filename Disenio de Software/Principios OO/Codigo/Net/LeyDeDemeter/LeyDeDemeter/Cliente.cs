using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeyDeDemeter
{
    class Cliente
    {
        Cartera _cartera = new Cartera(50);

        #region Variables Privadas

        private string _nombre;
        private string _apellido;
        private Cartera _miCartera;

        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }

        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }

            
        #endregion

        #region Métodos Publicos
        public float Pagar (float monto)
        {
            if (_cartera != null)
            {
                if (_cartera.Monto > monto)
                {
                    _cartera.SacarDinero(monto);
                    return monto;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
   

        }

 
        #endregion

    }
}
