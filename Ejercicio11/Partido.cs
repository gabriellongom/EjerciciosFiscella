using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Partido
    {
        public static int partidosJugados = 2;
        static Random r = new Random();
        public static int resMin = 0;
        public static int resMax = 3;

        private string[] partidos;

        public Partido()
        {
            partidos = new string[partidosJugados];
        }

        public void generarResultados()
        {

            int pLocal, pVisitante;

            for (int i = 0; i < partidos.Length; i++)
            {
                pLocal = r.Next(resMin, resMax);
                pVisitante = r.Next(resMin, resMax);

                partidos[i] = pLocal + " - " + pVisitante;
            }
        }

        public string[] Partidos
        {
            get
            {
                return partidos;
            }
        }
    }
}
