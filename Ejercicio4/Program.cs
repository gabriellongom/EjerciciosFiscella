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
        public static int precio_base_default = 100;
        public static string color_default = "blanco";
        public static char C_E_Default = 'F';
        public static double peso_default = 5;
        private static int precio_a = 100;
        private static int precio_b = 80;
        private static int precio_c = 60;
        private static int precio_d = 50;
        private static int precio_e = 30;
        private static int precio_f = 10;

        private int precio_base = precio_base_default;
        private string color = color_default;
        private char consumo_energetico = C_E_Default;
        private double peso = peso_default;


        public Electrodomestico()
        {

        }
        public Electrodomestico(int precio_base, double peso)
        {
            this.precio_base = precio_base;
            this.peso = peso;
        }
        public Electrodomestico(int precio_base, string color, char consumo, double peso)
        {
            this.precio_base = precio_base;
            this.color = color;
            consumo_energetico = consumo;
            this.peso = peso;
        }

        public int PrecioBase
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
                return Peso;
            }
        }
        
        private void ComprobarConsumoEnergetico(char letra)
        {
            if((int)letra < 65 && (int)letra > 70 && (int)letra < 97  && (int)letra > 102)
            {
                consumo_energetico = C_E_Default;
            }
            else if ((int)letra > 96 && (int)letra < 103)
            {
                consumo_energetico = char.ToUpper(letra);
            }
            else
            {
                consumo_energetico = letra;
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
        public virtual int PrecioFinal()
        {
            int precioCategoria = 0;
            int precioPeso = 0;

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

            if (peso >= 0 && peso < 20)
            {
                precioPeso = 10;
            }
            else if (peso >= 20 && peso < 50)
            {
                precioPeso = 50;
            }
            else if (peso >= 50 && peso < 80)
            {
                precioPeso = 80;
            }
            else if (peso >= 80)
            {
                precioPeso = 100;
            }

            int precio_final = precio_base + precioCategoria + precioPeso;
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
        public Lavadora(int carga, int precio_base, string color, char consumo, double peso) : base(precio_base,color,consumo,peso)
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

        public override int PrecioFinal()
        {
            int precioCarga = 0;


            int precio_final = PrecioBase + precioCategoria + precioPeso + precioCarga;
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
        public Television(int resolucion, bool sintonizador, int precio_base, string color, char consumo, double peso) : base(precio_base, color, consumo, peso)
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

        public override int PrecioFinal()
        {
            int precioRes = 0;
            int precioSint = 0;


            int precio_final = PrecioBase + precioCategoria + precioPeso + precioRes + precioSint;
            return precio_final;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico electrodomestico = new Electrodomestico(250, "azul", 'B', 40);
            Lavadora lavadora = new Lavadora(20, 250, "azul", 'B', 40);
        }
    }
}
