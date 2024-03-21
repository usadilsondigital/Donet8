using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleExists
    {
        public void example(string[] args)
        {
            string[] planets = { "Mercury", "Venus",
                "Earth", "Mars", "Jupiter",
                "Saturn", "Uranus", "Neptune" };


            Console.WriteLine("One or more planets begin with 'M': {0}",
                Array.Exists(planets, element => element.StartsWith("M")));


            Console.WriteLine("One or more planets begin with 'T': {0}",
                Array.Exists(planets, element => element.StartsWith("T")));



            Console.WriteLine("Is Pluto one of the planets? {0}",
                Array.Exists(planets, element => element == "Pluto"));


        }
    }
}
