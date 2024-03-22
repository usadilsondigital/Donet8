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

            // The example displays the following output:
            //       One or more planets begin with 'M': True
            //       One or more planets begin with 'T': False
            //       Is Pluto one of the planets? False
        }



        public  void example2()
        {
            String[] names = { "Adam", "Adel", "Bridgette", "Carla",
                         "Charles", "Daniel", "Elaine", "Frances",
                         "George", "Gillian", "Henry", "Irving",
                         "James", "Janae", "Lawrence", "Miguel",
                         "Nicole", "Oliver", "Paula", "Robert",
                         "Stephen", "Thomas", "Vanessa",
                         "Veronica", "Wilberforce" };

            Char[] charsToFind = { 'A', 'K', 'W', 'Z' };

            foreach (var charToFind in charsToFind)
                Console.WriteLine("One or more names begin with '{0}': {1}",
                                  charToFind,
                                  Array.Exists(names, (new StringSearcher(charToFind)).StartsWith));



        }


        public void searchWithLambaExpression()
        {
            String[] names = { "Adam", "Adel", "Bridgette", "Carla",
                         "Charles", "Daniel", "Elaine", "Frances",
                         "George", "Gillian", "Henry", "Irving",
                         "James", "Janae", "Lawrence", "Miguel",
                         "Nicole", "Oliver", "Paula", "Robert",
                         "Stephen", "Thomas", "Vanessa",
                         "Veronica", "Wilberforce" };

            Char[] charsToFind = { 'A', 'K', 'W', 'Z' };
            foreach (var charToFind in charsToFind)
                Console.WriteLine("One or more names begin with '{0}': {1}",
                                  charToFind,
                                  Array.Exists(names,
                                               s => {
                                                   if (string.IsNullOrEmpty(s))
                                                       return false;

                                                   if (s.Substring(0, 1).ToUpper() == charToFind.ToString())
                                                       return true;
                                                   else
                                                       return false;
                                               }));
            // The example displays the following output:
            //       One or more names begin with 'A': True
            //       One or more names begin with 'K': False
            //       One or more names begin with 'W': True
            //       One or more names begin with 'Z': False

        }






    }
}
