using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExampleSort
    {
        public void example1()
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

        /*After sorting a section of the Array using the reverse case-insensitive comparer:
        red       : strawberries
        YELLOW    : LIMES
        GREEN     : PEARS
        BLUE      : BERRIES
        purple    : grapes
        black     : olives
        orange    : cantaloupe
        */
        /*After sorting the entire Array using the default comparer:
           black     : olives
           BLUE      : BERRIES
           GREEN     : PEARS
           orange    : cantaloupe
           purple    : grapes
           red       : strawberries
           YELLOW    : LIMES*/


        /*After sorting the entire Array using the reverse case-insensitive comparer:
       YELLOW    : LIMES
       red       : strawberries
       purple    : grapes
       orange    : cantaloupe
       GREEN     : PEARS
       BLUE      : BERRIES
       black     : olives

    */
        public void example2()
        {
            // Create and initialize a new array.
            String[] words = { "The", "QUICK", "BROWN", "FOX", "jumps",
                         "over", "the", "lazy", "dog" };
            // Instantiate the reverse comparer.
            IComparer revComparer = new ReverseComparer();
            // Display the values of the array.
            Console.WriteLine("The original order of elements in the array:");
            DisplayValues(words);

            // Sort a section of the array using the default comparer.
            Array.Sort(words, 1, 3);

            Console.WriteLine("After sorting elements 1-3 by using the default comparer:");
            DisplayValues(words);

            // Sort a section of the array using the reverse case-insensitive comparer.
            Array.Sort(words, 1, 3, revComparer);
            Console.WriteLine("After sorting elements 1-3 by using the reverse case-insensitive comparer:");
            DisplayValues(words);

            // Sort the entire array using the default comparer.
            Array.Sort(words);
            Console.WriteLine("After sorting the entire array by using the default comparer:");
            DisplayValues(words);

            // Sort the entire array by using the reverse case-insensitive comparer.
            Array.Sort(words, revComparer);

            Console.WriteLine("After sorting the entire array using the reverse case-insensitive comparer:");
            DisplayValues(words);

            // The example displays the following output:
            //    The original order of elements in the array:
            //       [0] : The
            //       [1] : QUICK
            //       [2] : BROWN
            //       [3] : FOX
            //       [4] : jumps
            //       [5] : over
            //       [6] : the
            //       [7] : lazy
            //       [8] : dog

            //    After sorting elements 1-3 by using the default comparer:
            //       [0] : The
            //       [1] : BROWN
            //       [2] : FOX
            //       [3] : QUICK
            //       [4] : jumps
            //       [5] : over
            //       [6] : the
            //       [7] : lazy
            //       [8] : dog

            //    After sorting elements 1-3 by using the reverse case-insensitive comparer:
            //       [0] : The
            //       [1] : QUICK
            //       [2] : FOX
            //       [3] : BROWN
            //       [4] : jumps
            //       [5] : over
            //       [6] : the
            //       [7] : lazy
            //       [8] : dog

            //    After sorting the entire array by using the default comparer:
            //       [0] : BROWN
            //       [1] : dog
            //       [2] : FOX
            //       [3] : jumps
            //       [4] : lazy
            //       [5] : over
            //       [6] : QUICK
            //       [7] : the
            //       [8] : The

            //    After sorting the entire array using the reverse case-insensitive comparer:
            //       [0] : the
            //       [1] : The
            //       [2] : QUICK
            //       [3] : over
            //       [4] : lazy
            //       [5] : jumps
            //       [6] : FOX
            //       [7] : dog
            //       [8] : BROWN





        }


        public  void example3()
        {
            string[] dinosaurs = {"Pachycephalosaurus",
                              "Amargasaurus",
                              "Tyrannosaurus",
                              "Mamenchisaurus",
                              "Deinonychus",
                              "Edmontosaurus"};

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            Console.WriteLine("\nSort");
            Array.Sort(dinosaurs);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
            Console.WriteLine("\nBinarySearch for 'Coelophysis':");
            int index = Array.BinarySearch(dinosaurs, "Coelophysis");
            ShowWhere(dinosaurs, index);
            Console.WriteLine("\nBinarySearch for 'Tyrannosaurus':");

            index = Array.BinarySearch(dinosaurs, "Tyrannosaurus");
            ShowWhere(dinosaurs, index);




        }


        }

    private  void ShowWhere<T>(T[] array, int index)
    {
        if (index < 0)
        {
            // If the index is negative, it represents the bitwise
            // complement of the next larger element in the array.
            //
            index = ~index;
            Console.Write("Not found. Sorts between: ");

            if (index == 0)
                Console.Write("beginning of array and ");



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
