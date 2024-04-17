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
        }










        }
}