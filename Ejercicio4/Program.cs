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
        
        private void comprobarConsumoEnergetico(char letra)
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
        private void comprobarColor(string color)
        {
            Regex rx = new Regex(@"^[blanco]$+@""^[negro]$+@""^[rojo]$+@""^[azul]$+@""^[gris]$", RegexOptions.IgnoreCase);
            bool match = rx.IsMatch(color);
            if (match == true){
                this.color = color;
            }
            else
            {
                this.color = color_default;
            }
        }
        public int precioFinal()
        {
            int precioCategoria = 0;
            int precioPeso = 0;

            precioCategoria = ((int)consumo_energetico - 64) * 20;

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

    class Lavadora : Electrodomestico
    {
        public static int carga_def = 5;

        private int carga = carga_def;

        public Lavadora()
        {

        }
        public Lavadora(int precio, double peso)
        {

        }
        public Lavadora(int peso)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
 
        }
    }
}
