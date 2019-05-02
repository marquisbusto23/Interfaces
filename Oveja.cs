using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAnimal
{
    class Oveja : IHervico
    {
        public string Nombreanimal { get; set; }
        public string Comer()
        {
            return "vegetales";
        }
        public string Salvajismo()
        {
            return "domestico";
        }
        public string Viveen()
        {
            return "el campo";
        }
    }
}
