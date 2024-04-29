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
            Console.Write("{0,5}:", name);

            for (int loopX = arr.Length - 1; loopX >= 0; loopX--)
                Console.Write(format, arr.GetValue(loopX));
            Console.WriteLine();

        }


        public static void ArrayInfo(Array arr, string name, int index)
        {
            byte value = Buffer.GetByte(arr, index);


            // Display the array name, index, and byte to be viewed.
            Console.WriteLine(formatter, name, index, value,
                String.Format("0x{0:X2}", value));

        }

        public static void Main()
        {
            // These are the arrays to be viewed with GetByte.
            long[] longs =
            { 333333333333333333, 666666666666666666, 999999999999999999 };

            int[] ints =
            { 111111111, 222222222, 333333333, 444444444, 555555555 };

            Console.WriteLine("This example of the " +
                 "Buffer.GetByte( Array, int ) \n" +
                  "method generates the following output.\n" +


        }






    }
}
