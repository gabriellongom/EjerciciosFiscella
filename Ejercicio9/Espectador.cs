using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Espectador
    {
        public static string[] nombres = { "Jose", "Pepe", "Pablo", "Hernan", "Juan", "Ignacio", "Ezequiel", "Martin", "Fernando", "Alberto", "Cesar", "Gabriel", "Maximo", "Agustin", "Roberto", "Josefina", "Penelope", "Maria", "Martina", "Aylen", "Paula", "Daniela", "Carla", "Sofia", "Lucia", "Abril", "Anais", "Camila", "Soledad", "Sheila" };
        private string nombre;
        private int edad;
        private double dinero;

        public Espectador(string nombre, int edad, double dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
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

        public double Dinero
        {
            get
            {
                return dinero;
            }
            set
            {
                dinero = value;
            }
        }

        public bool EdadSuficiente(int edadMinima)
        {
            if (edad >= edadMinima)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DineroSuficiente(double entrada)
        {
            if (dinero >= entrada)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PagarEntrada(double entrada)
        {
            dinero -= entrada;
        }
    }
}
