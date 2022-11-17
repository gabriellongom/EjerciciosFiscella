using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Revolver
    {
        static Random r = new Random();

        int posicionActual;
        int posicionBala;

        public Revolver()
        {

        }

        public bool Disparar()
        {
            if (posicionActual == posicionBala)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SiguienteBala()
        {
            posicionActual++;
        }
    }
}
