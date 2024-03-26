using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleGetLowerBound
    {
        public  void Example()
        {
            // Create a one-dimensional integer array.
            int[] integers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            // Get the upper and lower bound of the array.
            int upper = integers.GetUpperBound(0);
            int lower = integers.GetLowerBound(0);

            Console.WriteLine($"Elements from index {lower} to {upper}:");



        }
    
    
    }

}
