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
            posicionActual = r.Next(1,6);
            posicionBala = r.Next(1,6);
        }

        public bool Disparar()
        {
            if (posicionActual == posicionBala)
            {
                SiguienteBala();
                return true;
            }
            else
            {
                SiguienteBala();
                return false;
            }

        }

        public void SiguienteBala()
        {
            if (posicionActual == 7)
            {
                posicionActual = 1;
            }
            else
            {
                posicionActual++;
            }
        }
    }
}
