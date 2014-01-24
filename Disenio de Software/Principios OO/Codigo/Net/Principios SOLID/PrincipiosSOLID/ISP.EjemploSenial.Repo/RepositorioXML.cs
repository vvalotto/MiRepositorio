using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using ISP.EjemploSenial.Modelo;

namespace ISP.EjemploSenial.Repo
{
	public class RepositorioXML:IRepositorio
    {
		string _ubicacion;

		public RepositorioXML(string ubicacion)
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


		#region IRepositorio implementation
		public void Guardar (Senial senial)
		{
			string _id = senial.Id.ToString ();
			string _fecha = senial.fecha_adquisicion.ToString ("yyyy MMMMM dd");
			string _nombre = _ubicacion + "/"+ _id + " - " + _fecha + ".xml";
			XmlWriter _xml =  XmlWriter.Create(_nombre);

			_xml.WriteStartDocument ();
			_xml.WriteStartElement ("cabecera");

			_xml.WriteStartElement ("descripcion");
			_xml.WriteString(senial.descripcion);
			_xml.WriteEndElement ();

			_xml.WriteStartElement ("fecha");
			_xml.WriteString(_fecha);
			_xml.WriteEndElement();

			_xml.WriteStartElement ("valores");
			for (int i = 1; i < senial.CantidadValores(); i++)
			{
				_xml.WriteElementString ("dato", senial.ObtenerValor (i - 1).ToString());

			}
			_xml.WriteEndElement();

			_xml.WriteEndDocument();
			_xml.Close ();

		}
		public Senial Recuperar (int id)
		{
			throw new NotImplementedException ();
		}

		public void Auditar (Senial senial, string programa)
		{
			string _nombreAuditor = "Auditor.log";
			using (StreamWriter auditor = File.AppendText (_nombreAuditor)) {
				auditor.WriteLine (">--------");
				auditor.WriteLine (senial.descripcion);
				auditor.WriteLine (senial.fecha_adquisicion.ToString ());
				auditor.WriteLine (programa);
			}

		}
		public void Trazar (Senial senial, string mensaje)
		{
			throw new NotImplementedException ();
		}
		#endregion
    }
}
