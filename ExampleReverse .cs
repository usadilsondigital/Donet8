using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleReverse
    {

        public void example() {
            // Creates and initializes a new Array.
            Array myArray = Array.CreateInstance(typeof(string), 9);
            myArray.SetValue("The", 0);
            myArray.SetValue("quick", 1);
            myArray.SetValue("brown", 2);
            myArray.SetValue("fox", 3);
            myArray.SetValue("jumps", 4);
            myArray.SetValue("over", 5);
            myArray.SetValue("the", 6);
            myArray.SetValue("lazy", 7);
            myArray.SetValue("dog", 8);
        }
    }
}
