﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleSort
    {
        public  void example1()
        {
            // Creates and initializes a new Array and a new custom comparer.
            String[] myKeys = { "red", "GREEN", "YELLOW", "BLUE", "purple", "black", "orange" };
            String[] myValues = { "strawberries", "PEARS", "LIMES", "BERRIES", "grapes", "olives", "cantaloupe" };
            IComparer myComparer = new myReverserClass();
            // Displays the values of the Array.
            Console.WriteLine("The Array initially contains the following values:");
            PrintKeysAndValues(myKeys, myValues);

            // Sorts a section of the Array using the default comparer.
            Array.Sort(myKeys, myValues, 1, 3);

            Console.WriteLine("After sorting a section of the Array using the default comparer:");
            PrintKeysAndValues(myKeys, myValues);

        }
        public static void PrintKeysAndValues(String[] myKeys, String[] myValues)
        {
            for (int i = 0; i < myKeys.Length; i++)
            {
                Console.WriteLine("   {0,-10}: {1}", myKeys[i], myValues[i]);
            }
            Console.WriteLine();
        }
    }
    /*
This code produces the following output.

The Array initially contains the following values:
   red       : strawberries
   GREEN     : PEARS
   YELLOW    : LIMES
   BLUE      : BERRIES
   purple    : grapes
   black     : olives
   orange    : cantaloupe
*/

    /*After sorting a section of the Array using the default comparer:
   red       : strawberries
   BLUE      : BERRIES
   GREEN     : PEARS
   YELLOW    : LIMES
   purple    : grapes
   black     : olives
   orange    : cantaloupe*/
    public class myReverserClass : IComparer
    {

        // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
        int IComparer.Compare(Object x, Object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }



}
