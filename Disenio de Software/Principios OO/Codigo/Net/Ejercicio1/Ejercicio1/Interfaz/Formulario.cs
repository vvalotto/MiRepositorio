using System;
using System.Collections.Generic;
using System.Reflection;
using Interfaz;

namespace Interfaz 
{
	public class Formulario : Pantalla, IFormulario 
    {

		public Formulario(){

		}


		/// <param name="Titulo"></param>
		public override void MostrarTitulo()
        {
            Console.Clear();
		}

		/// 
		/// <param name="objeto"></param>
		public void MostrarCampos(object objeto)
        {

            const string C = "System.String";
            Console.WriteLine(objeto.GetType());
            PropertyInfo[] mInfo = objeto.GetType().GetProperties();
            foreach (object o in mInfo)
            {

                Console.WriteLine((o.ToString()).Substring(C.Length + 1, (o.ToString().Length) - (C.Length + 1)));
               //Console.WriteLine(o.ToString());
            }
            
            Console.ReadLine();
         }

		public void IngresarCampos(){

		}

	}//end Formulario

}//end namespace Interfaz