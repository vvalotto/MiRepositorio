﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using ISP.EjemploSenial.Modelo;

namespace ISP.EjemploSenial.Modelo
{

    public abstract class Senial : ISenial
    {
        protected ArrayList _valores = new ArrayList();
        private DateTime _fecha_adquisicion;
		private string _descripcion;
		private int _id;

		public int Id {
			get {
				return _id;
			}
			set {
				_id = value;
			}
		}		 

        public DateTime fecha_adquisicion
        {
            get
            {
                return _fecha_adquisicion;
            }
			set{
				_fecha_adquisicion = value;
			}
        }

		public string descripcion {
			get {
				return _descripcion;
			}
			set {
				_descripcion = value;
			}
		}

        public Senial()
        {
            _fecha_adquisicion = DateTime.Now;
        }

        public decimal ObtenerValor(int indice)
        {
            return (decimal)this._valores[indice];
        }

        public void Limpiar()
        {
            this._valores.Clear();
        }

        public virtual void PonerValor(decimal valor)
        {
            this._valores.Add(valor);
        }

        public virtual int CantidadValores()
        {
            if (this._valores == null)
            {
                return 0;
            }
            else
            {
                return this._valores.Count;
            }
        }

        public virtual decimal SacarValor(int indice)
        {
            decimal _valor = 0;
            try
            {
                if (this._valores.Count != 0)
                {
                    _valor = this.ObtenerValor(indice);
                    this._valores.RemoveAt(indice);
                }
                else
                {
                    throw new System.InvalidOperationException("No hay nada para sacar");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return _valor;
        }

        public virtual decimal SacarValor()
        {
            throw new NotImplementedException();
        }
    }

    public class SenialBasica : Senial
    {
        public SenialBasica()
            : base()
        {

        }
    }
}
