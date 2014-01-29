using System;


namespace SOLID.Consola
{
    /*Adquisidor de datos desde el teclado*/
    public class AdquisidorSimple : Adquisidor
    {

        public AdquisidorSimple(Senial senial)
            : base(senial)
        {
        }

        protected override decimal LeerDatoEntrada()
        {
            string _datoEnt;
            decimal _dato;

            Console.Write("Ingresar Dato:");
            _datoEnt = Console.ReadLine();
            while (!decimal.TryParse(_datoEnt, out _dato))
            {
                Console.WriteLine("Dato mal ingresado, presione una tecla");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Ingresar Dato:");
                _datoEnt = Console.ReadLine();

            }
            return _dato;

        }

        public override void LeerSenial()
        {
			int _nroMuestra = 5;

            Console.WriteLine("Lectura de la Señal");
            for (int i = 1; i <= _nroMuestra; i++)
            {
                this._senial.PonerValor(LeerDatoEntrada());
                Console.WriteLine("Datos Ingresados:{0}", i.ToString());
            }

        }
    }

}
