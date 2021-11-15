using System;
using System.Collections.Generic;
using System.Text;

namespace InyecciondeDependencia
{
    public class PiñaColada:IBebida
    {

        public void Preparar()
        {
            Console.WriteLine("Haciendo una piña Colada");
        }
    }
}
