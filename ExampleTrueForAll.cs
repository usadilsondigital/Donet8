﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleTrueForAll
    {
        public  void example()
        {
            String[] values1 = { "Y2K", "A2000", "DC2A6", "MMXIV", "0C3" };
            String[] values2 = { "Y2", "A2000", "DC2A6", "MMXIV_0", "0C3" };

            if (Array.TrueForAll(values1, EndsWithANumber))
                Console.WriteLine("All elements end with an integer.");
            else
                Console.WriteLine("Not all elements end with an integer.");

            if (Array.TrueForAll(values2, EndsWithANumber))
                Console.WriteLine("All elements end with an integer.");
            else
                Console.WriteLine("Not all elements end with an integer.");


        }
        private  bool EndsWithANumber(string value)
        {
            int s;
            return int.TryParse(value.Substring(value.Length - 1), out s);
        }
        // The example displays the following output:
        //       Not all elements end with an integer.
        //       All elements end with an integer.


        public  void example2()
        {
            String[] values = { "Y2K", "A2000", "DC2A6", "MMXIV", "0C3" };
            if (Array.TrueForAll(values, value => {
                int s;
                return int.TryParse(value.Substring(value.Length - 1), out s);
            }
                  ))
                Console.WriteLine("All elements end with an integer.");
            else
                Console.WriteLine("Not all elements end with an integer.");

        }// The example displays the following output:

        //        Not all elements end with an integer.
    }
}
