using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal("Azorel", 5, 8.5f);
            Animal a3 = new Animal(a1);
            a1.Varsta = 3;
            a1.Nume = "Grivei";
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2.Nume);


            Animal a4 = (Animal)a2.Clone();


            Broasca b1 = new Broasca("Rafael", 150, 100, "verde", true);
            Console.WriteLine(b1);
            Girafa g1 = new Girafa("Sophie", 11, 80, 4, 250);
            Console.WriteLine(g1);
            Zebra z1 = new Zebra("Marti", 8, 50, 2, true);
            Console.WriteLine(z1);

            Zoo zoo = new Zoo();
            zoo.Animale.Add(a1);
            zoo.Animale.Add(a2);
            zoo.Animale.Add(b1);
            zoo.Animale.Add(g1);
            zoo.Animale.Add(z1);

            Zoo clonaZoo = (Zoo)zoo.Clone();
            foreach(Animal animale in clonaZoo.Animale)
            {
                animale.Nume += " Bucuresti";
            }
            zoo.Animale.Sort();
            Console.WriteLine(zoo);
            clonaZoo.Animale.Sort();
            Console.WriteLine(clonaZoo);
            Console.WriteLine("**********Operator Index************");
            Console.WriteLine(zoo[3]);
        }
    }
}
