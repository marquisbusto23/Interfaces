using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAnimal
{
    interface ICarnivoro: IAnimal
    {
        new string Nombreanimal { get; set; }
        new string Comer();

        new string Salvajismo();

        new string Viveen();
    }
}
