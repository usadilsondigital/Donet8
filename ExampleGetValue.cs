﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleGetValue
    {



        public  void example()
        {
            // Creates and initializes a one-dimensional array.
            String[] myArr1 = new String[5];


            // Sets the element at index 3.
            myArr1.SetValue("three", 3);
           
        }
    }


    /*
    This code produces the following output.

    [3]:   three
    [1,3]:   one-three
    [1,2,3]:   one-two-three
    [1,2,3,0,1,2,3]:   one-two-three-zero-one-two-three

    */




}
