using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleGetByteDemo
    {
        const string formatter = "{0,10}{1,10}{2,9} {3}";
        // Display the array contents in hexadecimal
        public static void DisplayArray(Array arr, string name)
        {
            // Get the array element width; format the formatting string.
            int elemWidth = Buffer.ByteLength(arr) / arr.Length;
            string format = String.Format(" {{0:X{0}}}", 2 * elemWidth);

            // Display the array elements from right to left.
        }
    }
}
