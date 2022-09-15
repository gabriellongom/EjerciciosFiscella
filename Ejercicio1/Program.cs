using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular)
        {
            this.titular = titular;
        }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string getTitular()
        {
            return titular;
        }

        public void setTitular(string titular)
        {
            this.titular = titular;
        }

        public double getCant()
        {
            return cantidad;
        }

        public void setCant(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public string CantToString()
        {
            return cantidad.ToString();
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad = +cantidad;
            }
        }

        public void Retirar(double cantidad)
        {
            if (this.cantidad - cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad = -cantidad;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("GabrielLongom");

            Console.WriteLine("El titular actual es " + cuenta.getTitular());
            cuenta.setTitular("GabrielLongombardo");
            Console.WriteLine("El titular actual es " + cuenta.getTitular());
            Console.WriteLine("La cantidad actual en su cuenta es de $" + cuenta.getCant());
            cuenta.setCant(500);
            Console.WriteLine("La cantidad actual en su cuenta es de $" + cuenta.getCant());
            cuenta.Ingresar(500);
            Console.WriteLine("La cantidad actual en su cuenta es $" + cuenta.CantToString());
            cuenta.Retirar(1100);
            Console.WriteLine("La cantidad actual en su cuenta es $" + cuenta.CantToString());

            Console.ReadKey();
        }
    }
}