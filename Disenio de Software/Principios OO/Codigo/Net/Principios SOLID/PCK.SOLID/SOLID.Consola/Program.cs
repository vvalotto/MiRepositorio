using System;


namespace SOLID.Consola
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            Console.Clear();
			Console.WriteLine("Programa Tratamiento Señal");
			ProgramaTratamientoSenial tratSenial = new ProgramaTratamientoSenial();
			tratSenial.Ejecutar();
			Console.WriteLine ("Fin");
			Console.ReadLine ();

		}
	}
}
