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
        
        public void Guardar(Senial senial)
        {
            
            string _linea_dato = "";
			string _fecha = senial.fecha_adquisicion.ToString ("yyyy MMMMM dd");
            string _cantidad = senial.CantidadValores().ToString();
			string _id = senial.Id.ToString ();
			string _nombre = _ubicacion + "/" + _id + " - " + _fecha + ".txt";

            try
            {
                using (StreamWriter _archivo = new StreamWriter(_nombre)) 
                {
                    string cabecera = _id + ";" + _fecha + ";" + _cantidad + ";";
                    _archivo.WriteLine(cabecera);

                    for (int i = 1; i <= senial.CantidadValores(); i++)
                    {
                        _linea_dato = i.ToString() + ";" + senial.ObtenerValor(i - 1).ToString() + ";";
                        _archivo.WriteLine(_linea_dato);
                    }

                    _archivo.Close();

                    this.Trazar(senial, "Se guardo la señal");
                    this.Auditar(senial, senial.GetType().ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                this.Trazar(senial, e.Message);
            }

        }

        public Senial Recuperar(int id)
        {
			/* Obtener todos los archivos .dat
			 * Para cada archivo, obtener la cabecera
			 * 		Parsear la cabecera
			 * 		Si el id es buscado
			 * 		Levantar la señal
			 * 
			 */
			bool _encontro = false;
			string _linea = "";
			SenialBasica _senialArchivada = new SenialBasica ();

			try{
				string [] _lista_datos = Directory.GetFiles(_ubicacion, "*.txt");
				Console.WriteLine("Hay {0} archivo/s", _lista_datos.Length.ToString());

				for (int i=0; !(_encontro); i++) {
					using (StreamReader _arch_datos = new StreamReader(_lista_datos[i]))
						{
							_linea = _arch_datos.ReadLine();
							Console.WriteLine(_linea);
							this.ParsearCabecera(_linea, _senialArchivada);
							if (_senialArchivada.Id == id) {
								_encontro = true;
								int j = 0;
								while((_linea = _arch_datos.ReadLine()) != null)
								{
									Console.WriteLine (_linea);	
									ParsearDato(_linea, _senialArchivada);
									Console.WriteLine("---> {0} : {1}",j, _senialArchivada.ObtenerValor(j));
									j++;
							}	
						}
					}
					
				}
				this.Trazar (_senialArchivada, "Se recupero la señal");
                this.Auditar(_senialArchivada, _senialArchivada.GetType().ToString());
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
				this.Trazar (_senialArchivada, e.Message);
				return null;
			}
			return _senialArchivada;
        }

		void ParsearCabecera(string cabecera, Senial senial)
		{

			string[] _cabecera;
			char[] charSeparators = new char[] {';'};
			_cabecera =  cabecera.Split(charSeparators,3) ;
			senial.Id = Convert.ToInt32(_cabecera [0]);
			senial.fecha_adquisicion = Convert.ToDateTime (_cabecera [1]);

		}

		void ParsearDato(string linea, Senial senial)
		{

			string[] _linea;
			char[] charSeparators = new char[] {';'};
			_linea =  linea.Split(charSeparators,3) ;
			senial.PonerValor (Convert.ToInt32 (_linea [1]));

		}


		public void Auditar(Senial senial, string programa)
        {
			string _nombreAuditor = "Auditor.log";
            using (StreamWriter auditor = File.AppendText(_ubicacion + "/" + _nombreAuditor))
            {
				auditor.WriteLine (">--------");
				auditor.WriteLine (senial.descripcion);
				auditor.WriteLine (senial.fecha_adquisicion.ToString ());
				auditor.WriteLine (programa);
			}
        }

		public void Trazar(Senial senial, string mensaje)
        {
			string _nombreLogger = "TrazaProcesos.log";
            using (StreamWriter _Logger = File.AppendText(_ubicacion + "/" + _nombreLogger))
            {
				_Logger.WriteLine (">-------- {0}", DateTime.Now.ToString ());
				_Logger.WriteLine (senial.descripcion);
				_Logger.WriteLine (senial.fecha_adquisicion.ToString ());
				_Logger.WriteLine (mensaje);
			}
        }
    }
}
