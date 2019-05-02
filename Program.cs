using System;
using System.Collections.Generic;

namespace InterfacesAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var animales = new List<IAnimal>();

            animales.Add(new Oveja { Nombreanimal = "Oveja" });
            
            animales.Add(new Perro { Nombreanimal = "Perro " });
            animales.Add(new Vaca { Nombreanimal = "Vaca" });         
            animales.Add(new Leon { Nombreanimal = "Leon" });

            foreach (IAnimal animal in animales)
            {
                Console.WriteLine("El/La "+ animal.Nombreanimal+" come "+ animal.Comer() );
                
            }
            Console.WriteLine();
            foreach (IAnimal animal in animales)
            {
                Console.WriteLine("El/La " + animal.Nombreanimal + " es " + animal.Salvajismo()+" y vive en "+animal.Viveen());
            }
            
        }
    }
}
