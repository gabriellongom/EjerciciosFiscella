﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Carta
    {
        public static string[] palos = { "Oros", "Copas", "Bastos", "Espadas" };
        public static int valor_max = 12;

        private string palo;
        private int valor;  
        private bool enMazo;

        public Carta(string palo, int valor)
        {
            this.palo = palo;
            this.valor = valor;
        }

    }
}
