using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Donet8
{
    public class ExampleLastIndexOf
    {
        // Creates and initializes a new Array with three elements of the same value.
        Array myArray = Array.CreateInstance(typeof(string), 12);
        myArray.SetValue( "the", 0 );
        myArray.SetValue( "quick", 1 );
        myArray.SetValue( "brown", 2 );
        myArray.SetValue( "fox", 3 );
        myArray.SetValue( "jumps", 4 );
            myArray.SetValue( "over", 5 );
            myArray.SetValue( "the", 6 );
            myArray.SetValue( "lazy", 7 );
            myArray.SetValue( "dog", 8 );
            myArray.SetValue( "in", 9 );
            myArray.SetValue( "the", 10 );
            myArray.SetValue( "barn", 11 );

            // Displays the values of the Array.
            Console.WriteLine( "The Array contains the following values:" );
            PrintIndexAndValues(myArray );


        // Searches for the last occurrence of the duplicated value.
        string myString = "the";
        int myIndex = Array.LastIndexOf(myArray, myString);
        Console.WriteLine( "The last occurrence of \"{0}\" is at index {1}.", myString, myIndex );

            // Searches for the last occurrence of the duplicated value in the first section of the Array.
        myIndex = Array.LastIndexOf(myArray, myString, 8 );
        Console.WriteLine( "The last occurrence of \"{0}\" between the start and index 8 is at index {1}.", myString, myIndex );

            // Searches for the last occurrence of the duplicated value in a section of the Array.
// Note that the start index is greater than the end index because the search is done backward.
myIndex = Array.LastIndexOf(myArray, myString, 10, 6 );
Console.WriteLine( "The last occurrence of \"{0}\" between index 5 and index 10 is at index {1}.", myString, myIndex );




    }
}
