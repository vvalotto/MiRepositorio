using System;


namespace SOLID.Consola
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            Console.Clear();
			Console.WriteLine("Ejmeplo DIP");
			Programa ejemDIP = new Programa();
		    ejemDIP.Ejecutar();
			Console.WriteLine ("Fin");
			Console.ReadLine ();

		}
	}
}
