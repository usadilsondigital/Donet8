﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleGetLength
    {
        public void Example() {
             // make a single dimension array
                Array MyArray1 = Array.CreateInstance(typeof(int), 5);

            // make a 3 dimensional array
            Array MyArray2 = Array.CreateInstance(typeof(int), 5, 3, 2);

            // make an array container
            Array BossArray = Array.CreateInstance(typeof(Array), 2);
            BossArray.SetValue(MyArray1, 0);
            BossArray.SetValue(MyArray2, 1);

            int i = 0, j, rank;
            foreach (Array anArray in BossArray)
            {
                rank = anArray.Rank;
                if (rank > 1)
                {
                    Console.WriteLine("Lengths of {0:d} dimension array[{1:d}]", rank, i);
                    // show the lengths of each dimension
                    for (j = 0; j < rank; j++)
                    {
                        Console.WriteLine("    Length of dimension({0:d}) = {1:d}", j, anArray.GetLength(j));
                    }
                }
                else
                {
                    Console.WriteLine("Lengths of single dimension array[{0:d}]", i);
                }
                // show the total length of the entire array or all dimensions

            }


        }
    }
}
