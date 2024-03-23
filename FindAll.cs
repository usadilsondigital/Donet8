﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class FindAll
    {

        public void example1()
        {
            // Get an array of n random integers.
            int[] values = GetArray(50, 0, 1000);
            int lBound = 300;
            int uBound = 600;
            int[] matchedItems = Array.FindAll(values, x => 
                                      x >= lBound && x <= uBound);

            for (int ctr = 0; ctr < matchedItems.Length; ctr++)
            {
                Console.Write("{0}  ", matchedItems[ctr]);
            }


        }



    }
}
