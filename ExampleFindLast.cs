using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleFindLast
    {

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
    }
}
