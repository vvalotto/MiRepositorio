using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace CCP.EjemploSenial.Utils
{
    public class LoggerArchivo : Logger
    {

        string _nombreArchivo;

        public string NombreArchivo
        {
            get { return _nombreArchivo; }
            set { _nombreArchivo = value; }
        }

        public override void IniTraza( Nivel nivel)
        {
            base.IniTraza(nivel);
            this._nombreArchivo = "Logger.log";
        }


        public override void Trazar(string mensaje, Nivel nivel)
        {
            if (base.Niveles[nivel] <= base.Niveles[_nivel])
            {
                using (StreamWriter logger = File.AppendText(this._nombreArchivo))
                {
                    logger.WriteLine("---- Logger");
                    logger.WriteLine(DateTime.Now.ToString());
                    logger.WriteLine(nivel.ToString() + " - " + mensaje);
                }
            }
        }

    }
}
