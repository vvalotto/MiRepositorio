using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeyDeDemeter
{
    class Cartera
    {
        #region Variables Privadas
        
        private float _monto = 0;

        #endregion
        
        #region Propiedades
        public float Monto
        {
            get
            {
                return _monto;
            }
            set
            {
                _monto = value;
            }
        }
        #endregion

        #region Métodos Publicos
        public void AgregarDinero(float deposito)
        {
            _monto += deposito;
        }
        public void SacarDinero(float debito)
        {
            _monto -= debito;
        }

        #endregion

        #region Contructor
        public Cartera()
        {
            this._monto = 0;
        }

        public Cartera(float montoInicial)
        {
            AgregarDinero(montoInicial);
        }
        #endregion
    }
}
