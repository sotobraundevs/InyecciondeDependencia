using System;
using System.Collections.Generic;
using System.Text;

namespace InyecciondeDependencia
{
    public class Cantinero
    {
        // PiñaColada bebida;
        IBebida bebida;

        public Cantinero(IBebida _bebida)
        {
            // this.bebida = new PiñaColada();
            this.bebida = _bebida;
        }

        public void Preparar()
        {
            this.bebida.Preparar();
        }


    }
}
