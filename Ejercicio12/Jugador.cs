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
        bool vivo;

        public Jugador(int id)
        {
            this.id = id;
            nombre = nombres[id];
            vivo = true;
        }

        public void Disparar(Revolver r)
        {
            
            if(r.Disparar() == true)
            {
                vivo = false;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public bool Vivo
        {
            get
            {
                return vivo;
            }
        }
    }
}
