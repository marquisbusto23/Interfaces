using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAnimal
{
    class Perro :ICarnivoro
    {
        public string Nombreanimal { get; set; }
        public string Comer()
        {
            return "carne";
        }
        public string Salvajismo()
        {
            return "domestico";
        }
        public string Viveen()
        {
            return "la casa con su amo";
        }
    }
}
