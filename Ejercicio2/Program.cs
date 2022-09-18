using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Persona
    {

        private static char Sexo_Default = 'H';
        public static int Peso_Ideal = 0;
        public static int Sobrepeso = 1;
        public static int Infrapeso = -1;

        private string nombre = "";
        private int edad = 0;
        private int DNIgenerado;
        private char sexo;
        private double peso = 0;
        private double altura = 0;

        public Persona()
        {
            DNIgenerado = GenerarDNI();
            sexo = Sexo_Default;
        }

        public Persona(string nombre,int edad,char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            ComprobarSexo();
            DNIgenerado = GenerarDNI();
        }

        public Persona(string nombre,int edad,char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            DNIgenerado = GenerarDNI();
            this.peso = peso;
            this.altura = altura;
            this.sexo = sexo;
            ComprobarSexo();
        }

        public double calcularIMC(double peso, double altura)
        {
            double relacPesoAltura;
            
            relacPesoAltura = peso / Math.Pow(altura,2);
            if(relacPesoAltura < 20)
            {
                return Infrapeso;
            }
            else if(relacPesoAltura >=20 && relacPesoAltura <=25)
            {
                return Peso_Ideal;
            }
            else
            {
                return Sobrepeso;
            }
        }

        public bool EsMayorDeEdad(int edad)
        {
            bool esMayor;

            if(edad >= 18)
            {
                esMayor = true;
            }
            else
            {
                esMayor = false;
            }

            return esMayor;
        }

        private void ComprobarSexo()
        {
            if(sexo != 'H' && sexo != 'M')
            {
                this.sexo = Sexo_Default;
            }
        }

        private int GenerarDNI()
        {
            Random dni = new Random();
            return dni.Next(10000000, 99999999);
        }

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public int GetDNI()
        {
            return DNIgenerado;
        }

        public char GetSexo()
        {
            return sexo;
        }
        public void SetSexo(char sexo)
        {
            this.sexo = sexo;
        }

        public double GetPeso()
        {
            return peso;
        }
        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public double GetAltura()
        {
            return altura;
        }
        public void SetAltura(double altura)
        {
            this.altura = altura;
        }
    }
    class Program
    {

        public static void IMC(Persona p)
        {
            double PesoPer = p.calcularIMC(p.GetPeso(), p.GetAltura());

            if (PesoPer == Persona.Sobrepeso)
            {
                Console.WriteLine("Esta persona tiene infrapeso");
            }
            else if (PesoPer == Persona.Infrapeso)
            {
                Console.WriteLine("Esta persona tiene sobrepeso");
            }
            else
            {
                Console.WriteLine("Esta persona tiene un peso perfecto");
            }
        }

        public static void EsMayorDeEdad(Persona p)
        {
            if (p.GetEdad() < 18)
            {
                Console.WriteLine("Esta persona es menor de edad");
            }
            else
            {
                Console.WriteLine("Esta persona es mayor de edad");
            }
        }

        public static void Datos(Persona p)
        {
            Console.WriteLine("NOMBRE: "+p.GetNombre());
            Console.WriteLine("EDAD: " + p.GetEdad());
            Console.WriteLine("DNI: " + p.GetDNI());
            Console.WriteLine("SEXO: " + p.GetSexo());
            Console.WriteLine("PESO: " + p.GetPeso());
            Console.WriteLine("ALTURA: " + p.GetAltura());
        }
        static void Main(string[] args)
        {
            Persona per3 = new Persona();

            per3.SetNombre("Martin");
            per3.SetEdad(34);
            per3.SetPeso(78);
            per3.SetAltura(1.86);

            Console.WriteLine("Ingrese el nombre de la otra persona");
            string f = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la otra persona");
            string g = Console.ReadLine();
            Console.WriteLine("Ingrese el genero de la otra persona (H = hombre, M = mujer)");
            char h = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            Persona per2 = new Persona(f, int.Parse(g), h);

            per2.SetPeso(68);
            per2.SetAltura(1.75);

            Console.WriteLine("Ingrese su nombre");
            string a = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            string b = Console.ReadLine();
            Console.WriteLine("Ingrese su genero (H = hombre, M = mujer)");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese su peso (En kilos)");
            string d = Console.ReadLine();
            Console.WriteLine("Ingrese su altura (En metros)");
            string e = Console.ReadLine();

            Persona per1 = new Persona(a, int.Parse(b), c, float.Parse(d), float.Parse(e));

            Console.WriteLine("\n\nPeso de la persona 1\n");

            IMC(per1);

            Console.WriteLine("\n\nPeso de la persona 2\n");

            IMC(per2);

            Console.WriteLine("\n\nPeso de la persona 3\n");

            IMC(per3);

            Console.WriteLine("\n\nEdad de la persona 1\n");

            EsMayorDeEdad(per1);

            Console.WriteLine("\n\nEdad de la persona 2\n");

            EsMayorDeEdad(per2);

            Console.WriteLine("\n\nEdad de la persona 3\n");

            EsMayorDeEdad(per3);

            Console.WriteLine("\n\nDatos de la persona 1\n");

            Datos(per1);

            Console.WriteLine("\n\nDatos de la persona 2\n");

            Datos(per2);

            Console.WriteLine("\n\nDatos de la persona 3\n");

            Datos(per3);

            Console.ReadKey();
        }
    }
}
