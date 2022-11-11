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
            List<Estudiantes> estudiantesTotal = new List<Estudiantes>(50);

            for (int i = 0; i < estudiantesTotal.Capacity; i++)
            {
                estudiantesTotal.Add(new Estudiantes());
            }

            Aulas aula = new Aulas();

            for (int j = 0; j < aula.Estudiantes.Capacity; j++)
            {
                Estudiantes e = estudiantesTotal[j];
                aula.Estudiantes.Add(e);
            }
                

            if (aula.DarClase() == true)
            {
                int alumnosAprobados = aula.DarNotas()[0];
                int alumnasAprobadas = aula.DarNotas()[1];

                Console.WriteLine("En este aula se puede dar clases, y hay " + alumnosAprobados + " alumnos aprobados y " + alumnasAprobadas + " alumnas aprobadas");

                aula.Show();
            }
            else
            {
                Console.WriteLine("En este aula no se puede dar clases");
            }
            Console.ReadKey();
        }
    }
}
