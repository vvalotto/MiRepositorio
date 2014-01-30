using System;


namespace SOLID.Consola
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            Console.Clear();
			Console.WriteLine("Ejmeplo DIP");
			ProgramaDIP ejemDIP = new ProgramaDIP();
		    ejemDIP.Ejecutar();
			Console.WriteLine ("Fin");
			Console.ReadLine ();

		}
	}
}
