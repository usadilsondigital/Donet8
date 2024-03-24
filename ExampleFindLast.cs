using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleFindLast
    {
        private string[] dinosaurs;
        public  void Main()
        {
            string[] dinosaurs =
            {
            "Compsognathus", "Amargasaurus", "Oviraptor",
            "Velociraptor",  "Deinonychus",  "Dilophosaurus",
            "Gallimimus",    "Triceratops"
        };

            DinoDiscoverySet GoMesozoic = new DinoDiscoverySet(dinosaurs);

            GoMesozoic.DiscoverAll();
            GoMesozoic.DiscoverByEnding("saurus");

        }

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

        public void DiscoverByEnding(string Ending)
        {
            Predicate<string> dinoType;
            switch (Ending.ToLower())
            {
                case "raptor":
                    dinoType = EndsWithRaptor;
                    break;
                case "tops":
                    dinoType = EndsWithTops;
                    break;
                case "saurus":
                default:
                    dinoType = EndsWithSaurus;
                    break;
            }

            Console.WriteLine("\nArray.Exists(dinosaurs, \"{0}\"): {1}",Ending,Array.Exists(dinosaurs, dinoType));

            Console.WriteLine(
            "\nArray.TrueForAll(dinosaurs, \"{0}\"): {1}",
            Ending,
            Array.TrueForAll(dinosaurs, dinoType));

            Console.WriteLine(
            "\nArray.Find(dinosaurs, \"{0}\"): {1}",
            Ending,
            Array.Find(dinosaurs, dinoType));


            Console.WriteLine(
            "\nArray.FindLast(dinosaurs, \"{0}\"): {1}",
            Ending,
            Array.FindLast(dinosaurs, dinoType));

            Console.WriteLine(
            "\nArray.FindAll(dinosaurs, \"{0}\"):", Ending);

        }

    }
    }
