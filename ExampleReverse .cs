using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleReverse
    {

        public void example() {
            // Creates and initializes a new Array.
            Array myArray = Array.CreateInstance(typeof(string), 9);
            myArray.SetValue("The", 0);
            myArray.SetValue("quick", 1);
            myArray.SetValue("brown", 2);
            myArray.SetValue("fox", 3);
            myArray.SetValue("jumps", 4);
            myArray.SetValue("over", 5);
            myArray.SetValue("the", 6);
            myArray.SetValue("lazy", 7);
            myArray.SetValue("dog", 8);

            // Displays the values of the Array.
            Console.WriteLine("The Array initially contains the following values:");
            PrintIndexAndValues(myArray);

            // Reverses the sort of the values of the Array.
            Array.Reverse(myArray);

            // Displays the values of the Array.
            Console.WriteLine("After reversing:");
            PrintIndexAndValues(myArray);

            /*
       This code produces the following output.

       The Array initially contains the following values:
           [0]:    The
           [1]:    quick
           [2]:    brown
           [3]:    fox
           [4]:    jumps
           [5]:    over
           [6]:    the
           [7]:    lazy
           [8]:    dog
       After reversing:
           [0]:    dog
           [1]:    lazy
           [2]:    the
           [3]:    over
           [4]:    jumps
           [5]:    fox
           [6]:    brown
           [7]:    quick
           [8]:    The
       */
        }
        public static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
        }

       

        public  void example2()
        {
            int nMonths = DateTimeFormatInfo.CurrentInfo.Calendar.GetMonthsInYear(DateTime.Now.Year);
            int[][] months = new int[nMonths][];


            // Populate elements with number of days in month.
            for (int ctr = 0; ctr <= months.GetUpperBound(0); ctr++)
            {
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, ctr + 1);
                months[ctr] = new int[daysInMonth];
                for (int ctr2 = 1; ctr2 <= daysInMonth; ctr2++)
                    months[ctr][ctr2 - 1] = ctr2;

            }

            foreach (var month in months)
            {
                foreach (var day in month)
                    Console.Write("{0} ", day);

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("About to reverse array.\n");
            Array.Reverse(months);


            foreach (var month in months)
            {
                foreach (var day in month)
                    Console.Write("{0} ", day);

                Console.WriteLine();
            }


        }
        // The example displays output similar to the following:
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //


        //    About to reverse array.
        //
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29
        //    1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31



        public  void example3()
        {

            // Creates and initializes a new Array.
            Array myArray = Array.CreateInstance(typeof(string), 9);
            myArray.SetValue("The", 0);
            myArray.SetValue("QUICK", 1);
            myArray.SetValue("BROWN", 2);
            myArray.SetValue("FOX", 3);
            myArray.SetValue("jumps", 4);
            myArray.SetValue("over", 5);
            myArray.SetValue("the", 6);
            myArray.SetValue("lazy", 7);
            myArray.SetValue("dog", 8);

            // Displays the values of the Array.
            Console.WriteLine("The Array initially contains the following values:");
            PrintIndexAndValues(myArray);


            // Reverses the sort of the values of the Array.
            Array.Reverse(myArray, 1, 3);

            // Displays the values of the Array.
            Console.WriteLine("After reversing:");
            PrintIndexAndValues(myArray);
        }

        public static void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
        }

    }
}
