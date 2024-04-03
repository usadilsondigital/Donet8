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


        }
    }

    public class myReverserClass : IComparer
    {

        // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
        int IComparer.Compare(Object x, Object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }



}
