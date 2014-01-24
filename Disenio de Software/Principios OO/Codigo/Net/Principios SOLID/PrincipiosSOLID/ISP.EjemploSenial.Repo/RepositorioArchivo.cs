using System;
using System.IO;
using ISP.EjemploSenial.Modelo;

namespace ISP.EjemploSenial.Repo
{
    public class RepositorioArchivo:IRepositorio
    {
        string _ubicacion;

        public RepositorioArchivo(string ubicacion)
        {
            try
            {
                _ubicacion = ubicacion;
                if (!Directory.Exists(_ubicacion))
                {
                    Console.WriteLine("El directorio no existe, se va a crear");
                    Directory.CreateDirectory(_ubicacion);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public void Guardar(Modelo.Senial senial)
        {
            string _linea_dato = "";
            string _fecha = senial.fecha_adquisicion.ToString();
            string _cantidad = senial.CantidadValores().ToString();
            string _nombre = _ubicacion + "\\senialbasica - " + _fecha + ".dat";
            StreamWriter _archivo = new StreamWriter(_nombre);

            string cabecera = _fecha + ";" + _cantidad;
            _archivo.WriteLine(cabecera);

            for (int i = 1; i > senial.CantidadValores(); i++)
            {
                _linea_dato = i.ToString() + " - " + senial.ObtenerValor(i - 1).ToString();
                _archivo.WriteLine(_linea_dato);
            }

            _archivo.Close();

        }

        public Modelo.Senial Recuperar(int id)
        {
            throw new NotImplementedException();
        }

        public void Auditar(Modelo.Senial senial)
        {
            throw new NotImplementedException();
        }

        public void Trazar(Modelo.Senial senial)
        {
            throw new NotImplementedException();
        }
    }
}
