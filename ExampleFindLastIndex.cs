using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleFindLastIndex
    {
        string[] dinosaurs = { "Compsognathus",
            "Amargasaurus",   "Oviraptor",      "Velociraptor",
            "Deinonychus",    "Dilophosaurus",  "Gallimimus",
            "Triceratops" };

        public void Example() {
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }


            Console.WriteLine(
          "\nArray.FindLastIndex(dinosaurs, EndsWithSaurus): {0}",
          Array.FindLastIndex(dinosaurs, EndsWithSaurus));

            Console.WriteLine(
          "\nArray.FindLastIndex(dinosaurs, 4, EndsWithSaurus): {0}",
          Array.FindLastIndex(dinosaurs, 4, EndsWithSaurus));


        }

    }
}
