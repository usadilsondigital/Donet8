using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleForeach
    {
        public void example()
        {
            // create a three element array of integers
            int[] intArray = new int[] { 2, 3, 4 };

            // set a delegate for the ShowSquares method
            Action<int> action = new Action<int>(ShowSquares);


            Array.ForEach(intArray, action);

        }


    }
}
