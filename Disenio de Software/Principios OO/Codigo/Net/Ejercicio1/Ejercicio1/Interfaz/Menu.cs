///////////////////////////////////////////////////////////
//  Menu.cs
//  Implementation of the Class Menu
//  Generated by Enterprise Architect
//  Created on:      25-oct-2011 11:00:34 a.m.
//  Original author: Victor
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using Interfaz;

namespace Interfaz {
    
    //Clase que prepara la seleccion de opciones 
	public class Menu : Pantalla, IMenu 
    {

        public Dictionary<char, string> _dOpciones = new Dictionary<char, string>();

        public Menu(string Titulo)
        {
            this._titulo = Titulo;
            this._pantalla = TipoMenu;
        }

		public override void MostrarTitulo()
        {
            Console.WriteLine(this._titulo);
            for (int i = 0; i < this._titulo.Length; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
		}

        public void MostrarOpciones()
        {
            foreach (KeyValuePair<char, string> pairOpcion in _dOpciones)
            {
                Console.WriteLine("{0} > {1}",pairOpcion.Key, pairOpcion.Value);
            }
   
		}

        public char SeleccionarOpcion()
        {
            char c;
            Console.Write("Opcion?:");
            c = Convert.ToChar(Console.Read());
            Console.WriteLine(c);
            Console.ReadLine();
            return c;
                                
        }           


        public void MostrarMenu()
        {
            Console.Clear();
            this.MostrarTitulo();
            this.MostrarOpciones();
        }

        public TipoPantalla TipoMenu { get; set; }

    }//end Menu

 
}//end namespace Interfaz