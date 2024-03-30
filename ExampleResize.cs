using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleResize
    {

        public  void Example()
        {

            // Create and initialize a new string array.
            String[] myArr = {"The", "quick", "brown", "fox", "jumps",
            "over", "the", "lazy", "dog"};



            // Display the values of the array.
            Console.WriteLine(
                "The string array initially contains the following values:");
            PrintIndexAndValues(myArr);


            // Resize the array to a bigger size (five elements larger).
            Array.Resize(ref myArr, myArr.Length + 5);


            // Display the values of the array.
            Console.WriteLine("After resizing to a larger size, ");
            Console.WriteLine("the string array contains the following values:");
            PrintIndexAndValues(myArr);

        }





    }
}
