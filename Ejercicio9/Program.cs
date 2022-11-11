using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static Random r = new Random();

        static void Main(string[] args)
        {
            
            Pelicula peli = new Pelicula("Mi vida", 90, 16, "DDR");

            Console.WriteLine("Cuantas filas de butacas tiene la sala?");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas Columnas de butacas tiene la sala?");
            int columnas = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto sale la entrada a la sala?");
            double precio = double.Parse(Console.ReadLine());

            Cine sala = new Cine(filas, columnas, precio, peli);

            Console.WriteLine("Cuanta gente vino a ver la pelicula");
            int CantEspectadores = int.Parse(Console.ReadLine());
            Espectador e;
            int fila;
            char letra;

            int cont = 0;

            Console.WriteLine("Espectadores: ");

            for (int i = 0; i < CantEspectadores && sala.haySitio(); i++)
            {
                e = new Espectador(Espectador.nombres[r.Next(0, Espectador.nombres.Length - 1)], r.Next(10, 30), r.Next(1, 15));

                cont++;
                Console.WriteLine("\n"+e.Nombre);
                Console.WriteLine(e.Edad);
                Console.WriteLine(e.Dinero);

                do
                {
                    fila = r.Next(0, sala.Filas - 1);
                    letra = (char)r.Next('A', 'A' + sala.Columnas - 1);
                } while (sala.haySitioButaca(fila, letra));

                if (sala.SePuedeSentar(e))
                {
                    e.PagarEntrada(precio);
                    sala.Sentar(fila, letra, e);
                }
            }

            Console.WriteLine("Información cine");
            Console.WriteLine("Pelicula reproducida: " + sala.Pelicula.Titulo);
            Console.WriteLine("Precio entrada: " + sala.Precio);
            Console.WriteLine("");
            for (int i = 0; i < sala.Asientos.Length; i++)
            {
                for (int j = 0; j < sala.Asientos[0].Length; j++)
                {
                    Console.WriteLine(sala.Asientos[i][j].Numero+""+sala.Asientos[i][j].Letra);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n" + cont);

            Console.ReadKey();
        }
    }
}
