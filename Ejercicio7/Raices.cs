using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Raices
    {
        private double a;
        private double b;
        private double c;
        public double raiz1;
        public double raiz2;

        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private void ObtenerRaices()
        {

            raiz1 = (-b + Math.Sqrt(GetDiscriminante())) / (2 * a);
            raiz2 = (-b - Math.Sqrt(GetDiscriminante())) / (2 * a);
        }

        private void ObtenerRaiz()
        {
            raiz1 = (-b) / (2 * a);
        }

        private double GetDiscriminante()
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }

        private bool tieneRaices()
        {
            if (GetDiscriminante() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool tieneRaiz()
        {
            if (GetDiscriminante() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Calcular()
        {
            if (tieneRaices())
            {
                ObtenerRaices();
                return 2;
            }
            else if (tieneRaiz())
            {
                ObtenerRaiz();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
