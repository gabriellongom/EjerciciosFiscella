using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Aulas aulas = new Aulas();

            if (aulas.DarClase() == true)
            {
                int alumnosAprobados = aulas.DarNotas()[0];
                int alumnasAprobadas = aulas.DarNotas()[1];

                Console.WriteLine("En este aula se puede dar clases, y hay " + alumnosAprobados + " alumnos aprobados y " + alumnasAprobadas + " alumnas aprobadas");

                aulas.Show();
            }
            else
            {
                Console.WriteLine("En este aula no se puede dar clases");
            }
            Console.ReadKey();
        }
    }
}
