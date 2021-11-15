using System;

namespace InyecciondeDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");

            // IBebida oPiñaColada = new PiñaColada();
            IBebida oPiñaColada = new Margarita();
            Cantinero ocantinero = new Cantinero(oPiñaColada);
            ocantinero.Preparar();

        }
    }
}
