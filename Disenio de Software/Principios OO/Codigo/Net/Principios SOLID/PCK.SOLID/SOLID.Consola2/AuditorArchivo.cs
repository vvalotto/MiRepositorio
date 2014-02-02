using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SOLID.Consola
{
    public class AuditorArchivo:IAuditable
    {
        string _nombreArchivo;

        public string NombreArchivo
        {
            get { return _nombreArchivo; }
            set { _nombreArchivo = value; }
        }
        

        public void Auditar(object usuario, object programa, object accion)
        {
            using (StreamWriter auditor = File.AppendText(_nombreArchivo))
            {
                auditor.WriteLine("Usuario: {0}; Programa: {1}; accion: {2}: mensaje {3}", usuario.ToString(), programa.ToString(), accion.ToString(), "NADA");

            }
        }
    }
}
