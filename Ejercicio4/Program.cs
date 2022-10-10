using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Electrodomestico
    {
        public static double precio_base_default = 100;
        public static string color_default = "blanco";
        public static char C_E_Default = 'F';
        public static double peso_default = 5;
        public static int precio_a = 100;
        public static int precio_b = 80;
        public static int precio_c = 60;
        public static int precio_d = 50;
        public static int precio_e = 30;
        public static int precio_f = 10;

        private double precio_base = precio_base_default;
        private string color = color_default;
        private char consumo_energetico = C_E_Default;
        private double peso = peso_default;
        public int precioCategoria = 0;
        public int precioPeso = 0;

        public Electrodomestico()
        {

        }
        public Electrodomestico(double precio_base, double peso)
        {
            this.precio_base = precio_base;
            this.peso = peso;
        }
        public Electrodomestico(double precio_base, string color, char consumo, double peso)
        {
            this.precio_base = precio_base;
            this.color = color;
            consumo_energetico = consumo;
            this.peso = peso;
            ComprobarColor(color);
            ComprobarConsumoEnergetico(consumo);
        }

        public double PrecioBase
        {
            get
            {
                return precio_base;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
        }
        
        public char ConsumoEnergetico
        {
            get
            {
                return consumo_energetico;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }
        }
        
        private void ComprobarConsumoEnergetico(char letra)
        {
            if((int)letra >= 65 && (int)letra <= 70)
            {
                consumo_energetico = letra;
            }
            else if ((int)letra >= 97 && (int)letra <= 102)
            {
                consumo_energetico = char.ToUpper(letra);
            }
            else
            {
                consumo_energetico = C_E_Default;
            }
        }
        private void ComprobarColor(string color)
        {
            Regex rx = new Regex(@"^[blanco]$|^[negro]$|^[rojo]$|^[azul]$|^[gris]$", RegexOptions.IgnoreCase);
            bool match = rx.IsMatch(color);
            if (match == true){
                this.color = color;
            }
            else
            {
                this.color = color_default;
            }
        }
        public virtual double PrecioFinal()
        {

            double precio_final;

            switch (ConsumoEnergetico)
            {
                case 'A':
                    precioCategoria = precio_a;
                    break;
                case 'B':
                    precioCategoria = precio_b;
                    break;
                case 'C':
                    precioCategoria = precio_c;
                    break;
                case 'D':
                    precioCategoria = precio_d;
                    break;
                case 'E':
                    precioCategoria = precio_e;
                    break;
                case 'F':
                    precioCategoria = precio_f;
                    break;
            }

            if (Peso >= 0 && Peso < 20)
            {
                precioPeso = 10;
            }
            else if (Peso >= 20 && Peso < 50)
            {
                precioPeso = 50;
            }
            else if (Peso >= 50 && Peso < 80)
            {
                precioPeso = 80;
            }
            else if (Peso >= 80)
            {
                precioPeso = 100;
            }

            precio_final = precio_base + precioCategoria + precioPeso;
            return precio_final;
        }
    }

    public class Lavadora : Electrodomestico
    {
        public static int carga_def = 5;

        private int carga = carga_def;

        public Lavadora()
        {

        }
        public Lavadora(int precio_base, double peso)
        {
            
        }
        public Lavadora(int carga, double precio_base, string color, char consumo, double peso) : base(precio_base,color,consumo,peso)
        {
            this.carga = carga;
        }

        public int Carga
        {
            get
            {
                return carga;
            }
        }

        public override double PrecioFinal()
        {
            int precioCarga = 0;

            switch (ConsumoEnergetico)
            {
                case 'A':
                    precioCategoria = precio_a;
                    break;
                case 'B':
                    precioCategoria = precio_b;
                    break;
                case 'C':
                    precioCategoria = precio_c;
                    break;
                case 'D':
                    precioCategoria = precio_d;
                    break;
                case 'E':
                    precioCategoria = precio_e;
                    break;
                case 'F':
                    precioCategoria = precio_f;
                    break;
            }

            if (Peso >= 0 && Peso < 20)
            {
                precioPeso = 10;
            }
            else if (Peso >= 20 && Peso < 50)
            {
                precioPeso = 50;
            }
            else if (Peso >= 50 && Peso < 80)
            {
                precioPeso = 80;
            }
            else if (Peso >= 80)
            {
                precioPeso = 100;
            }

            if (Carga > 30)
            {
                precioCarga = 50;
            }

            double precio_final = PrecioBase + precioCategoria + precioPeso + precioCarga;
            return precio_final;
        }
    }

    public class Television : Electrodomestico
    {
        public static int res_def = 20;
        public static bool sint_def = false;

        private int resolucion = res_def;
        private bool sintonizador = sint_def;

        public Television()
        {

        }
        public Television(int precio_base, double peso)
        {

        }
        public Television(int resolucion, bool sintonizador, double precio_base, string color, char consumo, double peso) : base(precio_base, color, consumo, peso)
        {
            this.resolucion = resolucion;
            this.sintonizador = sintonizador;
        }

        public int Resolucion
        {
            get
            {
                return resolucion;
            }
        }
        public bool Sintonizador
        {
            get
            {
                return sintonizador;
            }
        }

        public override double PrecioFinal()
        {
            double precioRes = 0;
            int precioSint = 0;

            if (sintonizador == true)
            {
                precioSint = 50;
            }

            switch (ConsumoEnergetico)
            {
                case 'A':
                    precioCategoria = precio_a;
                    break;
                case 'B':
                    precioCategoria = precio_b;
                    break;
                case 'C':
                    precioCategoria = precio_c;
                    break;
                case 'D':
                    precioCategoria = precio_d;
                    break;
                case 'E':
                    precioCategoria = precio_e;
                    break;
                case 'F':
                    precioCategoria = precio_f;
                    break;
            }

            if (Peso >= 0 && Peso < 20)
            {
                precioPeso = 10;
            }
            else if (Peso >= 20 && Peso < 50)
            {
                precioPeso = 50;
            }
            else if (Peso >= 50 && Peso < 80)
            {
                precioPeso = 80;
            }
            else if (Peso >= 80)
            {
                precioPeso = 100;
            }

            double precio_final = PrecioBase + precioCategoria + precioPeso + precioSint;

            if (resolucion > 40)
            {
                precioRes = precio_final * 0.3;
            }

            precio_final = precio_final + precioRes;

            return precio_final;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico electrodomestico1 = new Electrodomestico(250, "Azul", 'B', 40);
            Lavadora lavadora1 = new Lavadora(20, 350, "Negro", 'A', 20);
            Television television1 = new Television(30, false , 100, "Negro", 'q', 5); 
            Electrodomestico electrodomestico2 = new Electrodomestico(250, "Azul", 'B', 40);
            Lavadora lavadora2 = new Lavadora(35, 475, "Blanco", 'A', 25);
            Television television2 = new Television(60, true, 500, "Negro", 'A', 8); 
            Electrodomestico electrodomestico3 = new Electrodomestico(300, "Blanco", 'C', 30);
            Lavadora lavadora3 = new Lavadora(15, 350, "Verde", 'b', 17);
            Television television3 = new Television(40, false, 150, "Azul", 'B', 7); 
            Electrodomestico electrodomestico4 = new Electrodomestico(175, "rojo", 'C', 25);


            Electrodomestico[] listaProductos = {electrodomestico1, lavadora1, television1, electrodomestico2, lavadora2, television2, electrodomestico3, lavadora3, television3, electrodomestico4};

            

            double sumaPrecioElect = 0;
            double sumaPrecioTele = 0;
            double sumaPrecioLava = 0;

            
            for (int i = 0; i < listaProductos.Length; i++)
            {
                 
                if (listaProductos[i] is Electrodomestico)
                {
                    sumaPrecioElect += listaProductos[i].PrecioFinal();
                }

                if (listaProductos[i] is Lavadora)
                {
                    sumaPrecioLava += listaProductos[i].PrecioFinal();
                }
               
                if (listaProductos[i] is Television)
                {
                    sumaPrecioTele += listaProductos[i].PrecioFinal();
                }
            }

            Console.WriteLine("La suma del precio de los electrodomesticos es de " + sumaPrecioElect);
            Console.WriteLine("La suma del precio de las lavadoras es de " + sumaPrecioLava);
            Console.WriteLine("La suma del precio de las televisiones es de " + sumaPrecioTele);

            Console.ReadKey();
        }
    }
}
