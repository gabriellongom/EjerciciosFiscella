using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Baraja
    {
        public static int max_baraja = 40;
        static Random r = new Random();

        private Carta[] mazo;
        private int posicionMazo;
        
        public Baraja()
        {
            mazo = new Carta[max_baraja];
            posicionMazo = 0;
            for (int i = 0; i < Carta.palos.Length; i++)
            {
                for (int j = 0; j < Carta.valor_max; j++)
                {
                    if (!(j == 7 || j == 8))
                    {
                        if (j >= 9)
                        {
                            mazo[((i * (Carta.valor_max - 2)) + (j - 2))] = new Carta(Carta.palos[i], j + 1);
                        }
                        else
                        {
                            mazo[((i * (Carta.valor_max - 2)) + j)] = new Carta(Carta.palos[i], j + 1);
                        }

                    }
                }

            }
            Barajar();

        }

        public void Barajar()
        {
            int posicionRandom = 0;
            Carta carta;

            for (int i = 0; i < mazo.Length; i++)
            {
                posicionRandom = r.Next(0, max_baraja - 1);

                carta = mazo[i];
                mazo[i] = mazo[posicionRandom];
                mazo[posicionRandom] = carta;

            }
            this.posicionMazo = 0;
        }

        public Carta SiguienteCarta()
        {
            Carta carta;

            if (posicionMazo < max_baraja)
            {
                carta = mazo[posicionMazo++];
            }
            else
            {
                carta = mazo[posicionMazo];
            }
            return carta;
        }

        public int CartasDisponibles()
        {
            int disponibles = max_baraja - posicionMazo;
            return disponibles;
        }

        public Carta[] DarCartas(int num)
        {
            Carta[] cartas = new Carta[num];
            if (num <= max_baraja && CartasDisponibles() >= num)
            {
                for (int i = 0; i < cartas.Length; i++)
                {
                    cartas[i] = SiguienteCarta();
                }
            }
            return cartas;
        }

        public Carta CartasMonton()
        {
            if (cartasDisponible() == NUM_CARTAS)
            {
                System.out.println("No se ha sacado ninguna carta");
            }
            else
            {
                //Recorro desde 0 a la posSiguienteCarta
                for (int i = 0; i < posSiguienteCarta; i++)
                {
                    System.out.println(cartas[i]);
                }
            }
        }

        public Carta MostrarBaraja()
        {
            if (cartasDisponible() == 0)
            {
                System.out.println("No hay cartas que mostrar");
            }
            else
            {
                for (int i = posSiguienteCarta; i < cartas.length; i++)
                {
                    System.out.println(cartas[i]);
                }
            }
        }
    }
}
