using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class DictExample
    {       public static void Run()
        {
            Dictionary<string, int> Carbrands = new Dictionary<string, int>();
            Carbrands["Mercedese"] = 10;
            Carbrands["BMW"] = 20;
            Carbrands["Maruti"] = 15;
            Console.WriteLine("Car brands:");
            foreach (var item in Carbrands)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Carbrands["BMW"] += 5;
            Console.WriteLine($"\nUpdated BMW count: {Carbrands["BMW"]}");
            Carbrands.Remove("Maruti");
            Console.WriteLine("\nAfter removing Maruti, Car brands:");

            foreach (var item in Carbrands)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            //it is safe way if mercedese if commeted out it will not throw error
            if (Carbrands.TryGetValue("Mercedese", out int mercedeseCount))
            {
                Console.WriteLine($"\nMercedese count retrieved using TryGetValue: {mercedeseCount}");
            }
        }
    }
}
