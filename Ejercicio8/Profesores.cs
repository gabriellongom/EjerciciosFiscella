using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Profesores : Personas
    {
        private static string[] materias_posibles = { "Matematicas", "Filosofia", "Fisica" };
        static Random r = new Random();
        private string materia;

        public Profesores() : base()
        {
            
            materia = materias_posibles[r.Next(0, materias_posibles.Length - 1)];
            Edad = r.Next(27, 60);
        }

        public string Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
            }
        }

        public override void asistencia()
        {
            if (r.Next(0, 100) < 20)
            {
                Asistio = false;
            }
            else
            {
                Asistio = true;
            }   
        }
    }
}
