using System;
using System.Collections;
using System.Linq;
using System.Text;
using DIP.EjemploSenial.Utils;
using System.IO;


namespace DIP.EjemploSenial.Modelo
{
    public class SenialPila : Senial, ITrazable, IAuditable
    {
        int _tamanio;
        int _tope;

        string _nombreAuditor;
        string _nombreLogger;
        Nivel _nivelLog;

        public int tamanio
        {
            get
            {
                return _tamanio;
            }
            set
            {
                _tamanio = value;
            }
        }

        public SenialPila(int tamanio)
            : base()
        {
            _tamanio = tamanio;
            _tope = 0;
            base.descripcion = "Sin Descripcion";
        }

        public override void PonerValor(decimal valor)
        {
            try
            {
                if (_tope != _tamanio)
                {
                    base.PonerValor(valor);
                    _tope++;
                }
                else
                {
                    throw new System.InvalidOperationException("No se puede poner mas datos");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override decimal SacarValor()
        {
            decimal _valor = 0;

            try
            {
                if (_tope != 0)
                {
                    _valor = base.ObtenerValor(_tope - 1);
                    _valores.RemoveAt(_tope - 1);
                    _tope--;
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

        public override int CantidadValores()
        {
            return this._valores.Count;
        }
        
        public override void Limpiar()
        {
            base.Limpiar();
            _tope = 0;
        }

        public void Trazar(string mensaje, Nivel nivel)
        {
            if (this._nivelLog == nivel)
            {
                using (StreamWriter _Logger = File.AppendText(_nombreLogger))
                {
                    _Logger.WriteLine(">-------- {0}", DateTime.Now.ToString());
                    _Logger.WriteLine(this.descripcion);
                    _Logger.WriteLine(this.fecha_adquisicion.ToString());
                    _Logger.WriteLine(mensaje);
                }
            }
        }

        public void Auditar(object usuario, object programa, object accion )
        {
            
            using (StreamWriter auditor = File.AppendText(_nombreAuditor))
            {
                auditor.WriteLine("Usuario: {0}", usuario.ToString());
                auditor.WriteLine("Programa: {0}", programa.ToString());
                auditor.WriteLine("accion: {0}", accion.ToString());
                auditor.WriteLine(this.descripcion);
                auditor.WriteLine(this.fecha_adquisicion.ToString());
            }
        }


        public void IniTraza(string logger, Nivel nivel)
        {
            this._nivelLog = nivel;
            this._nombreLogger = logger;

        }
            

        public void IniAuditoria(string _auditor)
        {
            this._nombreAuditor = _auditor;
            

        }
    }
}
