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

            // Iterate the array.
            for (int ctr = lower; ctr <= upper; ctr++)
                Console.Write($"{(ctr == lower ? "   " : "")}{integers[ctr]}" +
                              $"{(ctr < upper ? ", " : Environment.NewLine)}");

            Console.WriteLine();

            // Create a two-dimensional integer array.
            int[,] integers2d = { {2, 4}, {3, 9}, {4, 16}, {5, 25},
                           {6, 36}, {7, 49}, {8, 64}, {9, 81} };


            // Get the number of dimensions.
            int rank = integers2d.Rank;
            Console.WriteLine($"Number of dimensions: {rank}");

            for (int ctr = 0; ctr < rank; ctr++)
                Console.WriteLine($"   Dimension {ctr}: " +
                                  $"from {integers2d.GetLowerBound(ctr)} to {integers2d.GetUpperBound(ctr)}");

        }
    
    
    }

}
