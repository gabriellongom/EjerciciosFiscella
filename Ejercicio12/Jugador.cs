using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Jugador
    {
        static Random r = new Random();
        public static string[] nombres = { "Jose", "Pepe", "Pablo", "Hernan", "Juan", "Ignacio", "Ezequiel", "Martin", "Fernando", "Alberto", "Cesar", "Gabriel", "Maximo", "Agustin", "Roberto", "Josefina", "Penelope", "Maria", "Martina", "Aylen", "Paula", "Daniela", "Carla", "Sofia", "Lucia", "Abril", "Anais", "Camila", "Soledad", "Sheila" };

        int id;
        string nombre;
        bool vivo = true;

        public Jugador()
        {

        }

        public void Disparar(Revolver r)
        {
            r.Disparar();
            if()
        }
    }
}
