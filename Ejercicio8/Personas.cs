using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal abstract class Personas
    {

        private static string[] nombres_chicos = { "Jose", "Pepe", "Pablo", "Hernan", "Juan", "Ignacio", "Ezequiel", "Martin", "Fernando", "Alberto", "Cesar", "Gabriel", "Maximo", "Agustin", "Roberto" };
        private static string[] nombres_chicas = { "Josefina", "Penelope", "Maria", "Martina", "Aylen", "Paula", "Daniela", "Carla", "Sofia", "Lucia", "Abril", "Anais", "Camila", "Soledad", "Sheila" };


        private string nombre;
        private int edad;
        private char sexo;
        private bool asistio;



        public Personas()
        {
            Random r = new Random();

            int s = r.Next(0, 2);

            if (s == 0)
            {
                nombre = nombres_chicos[r.Next(0, nombres_chicos.Length - 1)];
                sexo = 'H';
            }
            else
            {
                nombre = nombres_chicas[r.Next(0, nombres_chicas.Length - 1)];
                sexo = 'M';
            }


            asistencia();
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }

        public bool Asistio
        {
            get
            {
                return asistio;
            }
            set
            {
                asistio = value;
            }
        }

        public abstract void asistencia();

    }
}
