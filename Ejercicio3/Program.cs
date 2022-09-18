using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Password
    {
        private string contraseña;
        private int longitud = 8;

        public Password()
        {
            contraseña = GenerarPassword();
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            contraseña = GenerarPassword();
        }

        public bool EsFuerte()
        {
            int CantMayus = 0;
            int CantMinus = 0;
            int CantNums = 0;

            for (int z = 0; z < contraseña.Length; z++)
            {
                //contraseña.GetEnumerator();
                char caracter = contraseña[z];

                if (char.IsDigit(caracter))
                {
                    CantNums++;
                }
                else if (char.IsUpper(caracter))
                {
                    CantMayus++;
                }
                else
                {
                    CantMinus++;
                }
            }

            if (CantMayus > 2 && CantMinus > 1 && CantNums > 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private string GenerarPassword()
        {
            string contraLocal = "";
            char[] letras = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            Random random = new Random();
            for (int i = 0; i < this.longitud; i++)
            {
                int letraR = random.Next(letras.Length);
                contraLocal = contraLocal + letras[letraR];
            }
            return contraLocal;
        }

        public string GetContra()
        {
            return contraseña;
        }

        public void SetContra(string contraseña)
        {
            this.contraseña = contraseña;
        }

        public int GetLongitud()
        {
            return longitud;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int CantPass = 0;
            string longiAInt;
            Console.WriteLine("Cuantas Contraseñas va a ingresar?");
            CantPass = int.Parse(Console.ReadLine());
            Password[] ArrayContraseñas = new Password[CantPass];
            bool[] ArrayFuertes = new bool[CantPass];
            Console.WriteLine("Que tan largas seran las contraseñas? (Cantidad de digitos)");
            longiAInt = Console.ReadLine();


            for (int index = 0; index < ArrayContraseñas.Length; index++)
            {

                Password pass = new Password(int.Parse(longiAInt));
                ArrayContraseñas[index] = pass;
                ArrayFuertes[index] = pass.EsFuerte();

                Console.WriteLine("\nContraseña "+ (index+1));
                Console.WriteLine(ArrayContraseñas[index].GetContra());
                Console.WriteLine(ArrayFuertes[index]+"\n\n");
                
                

            }
            Console.ReadKey();
        }
    }
}
