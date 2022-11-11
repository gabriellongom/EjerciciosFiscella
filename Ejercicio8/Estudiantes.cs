using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Estudiantes : Personas
    {
        static Random r = new Random();
        private int nota;

        public Estudiantes() : base()
        {

            nota = r.Next(0, 10);
            Edad = r.Next(13, 17);
        }

        public int Nota
        {
            get
            {
                return nota;
            }
            set
            {
                nota = value;
            }
        }

        public override void asistencia()
        {
            if (r.Next(0, 100) < 50)
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
