using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleIndexOf
    {
        // Create a string array with 3 elements having the same value.
        String[] strings = { "the", "quick", "brown", "fox", "jumps","over", "the", "lazy", "dog", "in", "the","barn" };

        // Display the elements of the array.
        Console.WriteLine("The array contains the following values:");
        for (int i = strings.GetLowerBound(0); i <= strings.GetUpperBound(0); i++)
           Console.WriteLine("   [{0,2}]: {1}", i, strings[i]);


    }
}
