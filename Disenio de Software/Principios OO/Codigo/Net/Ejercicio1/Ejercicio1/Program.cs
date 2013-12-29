using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaz;
using Entidades;
using Controlador;

namespace Ejercicio1
{
    class Program
    { 
        Menu Menu1 = new Menu("Menu Principal");
        Menu Menu2 = new Menu("Menú de Materias");
        Formulario FormAlumno = new Formulario();
        Alumno unAlumno = new Alumno();

        static void Main(string[] args)
        {
            Program p = new Program();
            //Mostrar pantallas
            p.Inicializar();
            char ipantalla = 'P';
            while (ipantalla != 'S')
            {
                switch (ipantalla)
                {
                    case 'P':
                        ipantalla = p.MostrarMenuPrincipal();
                        break;
                    case 'D': 
                        ipantalla = p.MostrarMenuMaterias();
                        break;
                    case 'V':
                        ipantalla = p.MostrarDesempenio();
                        break;
                    case 'A':
                        ipantalla = p.MostrarFormularioAlumno();
                        break;
                    
                    default:
                        Console.WriteLine("Chau");
                        break;
                }
            }
    
       }

       
       public void Inicializar()
       {
            Menu1._dOpciones.Add('A', "Ingresar Alumno");
            Menu1._dOpciones.Add('D', "Ingresar Desempeño");
            Menu1._dOpciones.Add('V', "Mostrar Desempeño");
            Menu2._dOpciones.Add('M', "Ingresar Materia");
            Menu2._dOpciones.Add('S', "Salir");
       }

       public char MostrarMenuPrincipal()
       {

            Menu1.MostrarMenu();
            return Menu1.SeleccionarOpcion();
        }


       public char MostrarMenuMaterias()
       {
           
           Menu2.MostrarMenu();
           return Menu2.SeleccionarOpcion();
       }

       public char MostrarDesempenio()
       {
           Console.Clear();
           Console.WriteLine("D");
           Console.ReadLine();
           return 'A';
       }

       public char MostrarFormularioAlumno()
       {
           FormAlumno.MostrarTitulo();
           FormAlumno.MostrarCampos(unAlumno);
           return 'A';
       }
    }
}
