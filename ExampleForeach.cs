using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleForeach
    {
        //The following example shows how to use ForEach to display the squares of each element in an integer array.
        public void example()
        {
            // create a three element array of integers
            int[] intArray = new int[] { 2, 3, 4 };

            // set a delegate for the ShowSquares method
            Action<int> action = new Action<int>(ShowSquares);


            Array.ForEach(intArray, action);

        }

        private static void ShowSquares(int val)
        {
            Console.WriteLine("{0:d} squared = {1:d}", val, val * val);
        }
        /*
            This code produces the following output:

            2 squared = 4
            3 squared = 9
            4 squared = 16
            */

    }
}
