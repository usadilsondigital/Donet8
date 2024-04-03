using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleSetValue
    {

        public void example1()
        {

            // Creates and initializes a one-dimensional array.
            String[] myArr1 = new String[5];
            // Sets the element at index 3.
            myArr1.SetValue("three", 3);
            Console.WriteLine("[3]:   {0}", myArr1.GetValue(3));

            // Creates and initializes a two-dimensional array.
            String[,] myArr2 = new String[5, 5];

            // Sets the element at index 1,3.
            myArr2.SetValue("one-three", 1, 3);

            Console.WriteLine("[1,3]:   {0}", myArr2.GetValue(1, 3));



        }
    }
}
