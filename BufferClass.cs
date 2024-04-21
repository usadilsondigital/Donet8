﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    //Manipulates arrays of primitive types.
    public class BufferClass
    {

        public  void DisplayArray(short[] arr)
        {
            Console.Write("  arr:");
            for (int loopX = arr.Length - 1; loopX >= 0; loopX--)
                Console.Write(" {0:X4}", arr[loopX]);
            Console.WriteLine();

        }

        public  void example1()
        {
            // This array is to be modified and displayed.
            short[] arr = { 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271 };
            Console.WriteLine("This example of the Buffer class " +
                 "methods generates the following output.\n" +
                 "Note: The array is displayed from right to left.\n");
            Console.WriteLine("Initial values of array:\n");
            // Display the initial array values and ByteLength.
            DisplayArray(arr);
            Console.WriteLine("\nBuffer.ByteLength( arr ): {0}",
                Buffer.ByteLength(arr));

            // Copy a region of the array; set a byte within the array.
            Console.WriteLine("\nCall these methods: \n" +
                 "  Buffer.BlockCopy( arr, 5, arr, 16, 9 ),\n" +
                  "  Buffer.SetByte( arr, 7, 170 ).\n");

            Buffer.BlockCopy(arr, 5, arr, 16, 9);
            Buffer.SetByte(arr, 7, 170);

            // Display the array and a byte within the array.
            Console.WriteLine("Final values of array:\n");
            DisplayArray(arr);
            Console.WriteLine("\nBuffer.GetByte( arr, 26 ): {0}",
                   Buffer.GetByte(arr, 26));

            /*
                This example of the Buffer class methods generates the following output.
            Note: The array is displayed from right to left.

            Initial values of array:
            arr: 010F 010E 010D 010C 010B 010A 0109 0108 0107 0106 0105 0104 0103 0102
            Buffer.ByteLength( arr ): 28
            Call these methods:
            Buffer.BlockCopy( arr, 5, arr, 16, 9 ),
            Buffer.SetByte( arr, 7, 170 ).
            Final values of array:
             arr: 010F 0101 0801 0701 0601 0501 0109 0108 0107 0106 AA05 0104 0103 0102
            Buffer.GetByte( arr, 26 ): 15

            */
        }


        //// Display the individual bytes in the array in hexadecimal.
        public void exampleDisplayArray(Array arr, string name) {

            Console.WindowWidth = 120;
            Console.Write("{0,11}:", name);
            for (int ctr = 0; ctr < arr.Length; ctr++)
            {
                byte[] bytes;
                if (arr is long[])
                    bytes = BitConverter.GetBytes((long)arr.GetValue(ctr));
                else
                    bytes = BitConverter.GetBytes((short)arr.GetValue(ctr));

                foreach (byte byteValue in bytes)
                    Console.Write(" {0:X2}", byteValue);
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        // Display the individual array element values in hexadecimal.
        public static void DisplayArrayValues(Array arr, string name)
        {
            // Get the length of one element in the array.
            int elementLength = Buffer.ByteLength(arr) / arr.Length;
            string formatString = String.Format(" {{0:X{0}}}", 2 * elementLength);
            Console.Write("{0,11}:", name);
            for (int ctr = 0; ctr < arr.Length; ctr++)
                Console.Write(formatString, arr.GetValue(ctr));
            Console.WriteLine();

        }

        public void example2()
        {
            // These are the source and destination arrays for BlockCopy.
            short[] src = { 258, 259, 260, 261, 262, 263, 264,265, 266, 267, 268, 269, 270 };
            long[] dest = { 17, 18, 19, 20 };
            // Display the initial value of the arrays in memory.
            Console.WriteLine("Initial values of arrays:");
            Console.WriteLine("   Array values as Bytes:");
            DisplayArray(src, "src");
            DisplayArray(dest, "dest");
            Console.WriteLine("   Array values:");
            DisplayArrayValues(src, "src");
            DisplayArrayValues(dest, "dest");
            Console.WriteLine();
            // Copy bytes 5-10 from source to index 7 in destination and display the result.
            Buffer.BlockCopy(src, 16, dest, 22, 5);
            Console.WriteLine("Buffer.BlockCopy(src, 16, dest, 22, 5)");
            Console.WriteLine("   Array values as Bytes:");
            DisplayArray(src, "src");
            DisplayArray(dest, "dest");
            Console.WriteLine("   Array values:");
            DisplayArrayValues(src, "src");
            DisplayArrayValues(dest, "dest");
            Console.WriteLine();

            // Copy overlapping range of bytes 4-10 to index 5 in source.
            Buffer.BlockCopy(src, 4, src, 5, 7);
            Console.WriteLine("Buffer.BlockCopy( src, 4, src, 5, 7)");
            Console.WriteLine("   Array values as Bytes:");
            DisplayArray(src, "src");
            DisplayArray(dest, "dest");
            Console.WriteLine("   Array values:");
            DisplayArrayValues(src, "src");
            DisplayArrayValues(dest, "dest");





        }










    }
    }
