using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Asiento
    {
        private char letra;
        private int numero;
        private Espectador espectador;

        public Asiento(char letra, int numero)
        {
            this.letra = letra;
            this.numero = numero;
            this.espectador = null;
        }

        public char Letra
        {
            get
            {
                return letra;
            }
            set
            {
                letra = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public Espectador Espectador
        {
            get
            {
                return espectador;
            }
            set
            {
                espectador = value;
            }
        }

        public bool AsientoOcupado()
        {
            if (espectador != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
