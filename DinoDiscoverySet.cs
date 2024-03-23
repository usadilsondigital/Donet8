using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class DinoDiscoverySet
    {
        public static void Main()
        {
            string[] dinosaurs = { "Compsognathus", "Amargasaurus", "Oviraptor",
            "Velociraptor",  "Deinonychus",  "Dilophosaurus","Gallimimus",    "Triceratops"};

            DinoDiscoverySet GoMesozoic = new DinoDiscoverySet(dinosaurs);

            GoMesozoic.DiscoverAll();
            GoMesozoic.DiscoverByEnding("saurus");

        }
        private string[] dinosaurs;

        public DinoDiscoverySet(string[] items)
        {
            dinosaurs = items;
        }
        public void DiscoverAll()
        {
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
        }



    }
}
