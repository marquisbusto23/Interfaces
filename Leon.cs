using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAnimal
{
    class Leon: ICarnivoro
    {
        public string Nombreanimal { get; set; }
        public string Comer()
        {
            return "carne";
        }
        public string Salvajismo()
        {
            return "salvaje";
        }
        public string Viveen()
        {
            return "la selva o sabana";
        }
    }
}
