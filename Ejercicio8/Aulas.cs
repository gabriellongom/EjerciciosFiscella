using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Aulas
    {
        private static string[] materias_posibles = { "Matematicas", "Filosofia", "Fisica" };
        private static int espacio_aula = 30;
        static Random r = new Random();

        private int id;
        private Profesores profesores;
        List<Estudiantes> estudiantes;
        private string materia;


        public Aulas()
        {

            id = r.Next(1, 999);
            materia = materias_posibles[r.Next(0, materias_posibles.Length - 1)];
            profesores = new Profesores();
            estudiantes = new List<Estudiantes>(espacio_aula);
        }

        public List<Estudiantes> Estudiantes
        {
            get
            {
                return estudiantes;
            }

            set
            {
                estudiantes = value;
            }
        }

        private bool AsistenciasNecesarias()
        {
            int asistencias_totales = 0;

            foreach (var estudiante in estudiantes)
            {
                if (estudiante.Asistio == true)
                {
                    asistencias_totales++;
                }
            }

            if (asistencias_totales > estudiantes.Count / 2)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool DarClase()
        {
            if (profesores.Asistio == true && AsistenciasNecesarias() == true && profesores.Materia == materia)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int[] DarNotas()
        {
            int[] aprobados = new int[2];
            foreach (var estudiante in estudiantes)
            {
                if(estudiante.Nota >= 6)
                {
                    if(estudiante.Sexo == 'H')
                    {
                        aprobados[0]++;
                    }
                    else
                    {
                        aprobados[1]++;
                    }
                }
            }
            return aprobados;
        }

        public void Show()
        {
            for(int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine("Estudiante "+i+":");
                Console.WriteLine(estudiantes[i].Nombre);
                Console.WriteLine(estudiantes[i].Edad);
                Console.WriteLine(estudiantes[i].Sexo);
                Console.WriteLine(estudiantes[i].Asistio);
                Console.WriteLine(estudiantes[i].Nota+"\n");
            }
        }
    }
}