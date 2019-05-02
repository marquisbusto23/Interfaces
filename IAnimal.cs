using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAnimal
{
    interface IAnimal
    {
        string Nombreanimal { get; set; }
        string Comer();

        string Salvajismo();

        string Viveen();
    }
}
