using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Donet8
{
    //Provides methods for creating,
    //manipulating, searching, and sorting arrays, thereby serving as the base class for all arrays in the common language runtime.
    public class ClassArray
    {
        public void TestCase()
        {

            // Creates and initializes a new integer array and a new Object array.
            int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
            Object[] myObjArray = new Object[5] { 26, 27, 28, 29, 30 };

            // Prints the initial values of both arrays.
            Console.WriteLine("Initially,");
            Console.Write("integer array:");
            PrintValues(myIntArray);
            Console.Write("Object array: ");
            PrintValues(myObjArray);

            // Copies the first two elements from the integer array to the Object array.
            System.Array.Copy(myIntArray, myObjArray, 2);

            // Prints the values of the modified arrays.
            Console.WriteLine("\nAfter copying the first two elements of the integer array to the Object array,");
            Console.Write("integer array:");
            PrintValues(myIntArray);
            Console.Write("Object array: ");
            PrintValues(myObjArray);

            // Copies the last two elements from the Object array to the integer array.
            System.Array.Copy(myObjArray, myObjArray.GetUpperBound(0) - 1, myIntArray, myIntArray.GetUpperBound(0) - 1, 2);

            // Prints the values of the modified arrays.
            Console.WriteLine("\nAfter copying the last two elements of the Object array to the integer array,");
            Console.Write("integer array:");
            PrintValues(myIntArray);
            Console.Write("Object array: ");
            PrintValues(myObjArray);

            /*
                This code produces the following output.

                Initially,
                integer array:  1       2       3       4       5
                Object array:   26      27      28      29      30

                After copying the first two elements of the integer array to the Object array,
                integer array:  1       2       3       4       5
                Object array:   1       2       28      29      30

                After copying the last two elements of the Object array to the integer array,
                integer array:  1       2       3       29      30
                Object array:   1       2       28      29      30
                */

        }


        public static void PrintValues(Object[] myArr)
        {
            foreach (Object i in myArr)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
        }


        public static void PrintValues(int[] myArr)
        {
            foreach (int i in myArr)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
        }

        //////
        ///
        public void ArrayThreeDimensional() {

            // Creates and initializes a new three-dimensional Array of type int.
            Array myArr = Array.CreateInstance(typeof(int), 2, 3, 4);
            for (int i = myArr.GetLowerBound(0); i <= myArr.GetUpperBound(0); i++)
            {
                for (int j = myArr.GetLowerBound(1); j <= myArr.GetUpperBound(1); j++)
                {
                    for (int k = myArr.GetLowerBound(2); k <= myArr.GetUpperBound(2); k++)
                    {
                        myArr.SetValue((i * 100) + (j * 10) + k, i, j, k);
                    }
                }
            }


            // Displays the properties of the Array.
            Console.WriteLine("The Array has {0} dimension(s) and a total of {1} elements.", myArr.Rank, myArr.Length);
            Console.WriteLine("\tLength\tLower\tUpper");
            for (int i = 0; i < myArr.Rank; i++)
            {
                Console.Write("{0}:\t{1}", i, myArr.GetLength(i));
                Console.WriteLine("\t{0}\t{1}", myArr.GetLowerBound(i), myArr.GetUpperBound(i));
            }
            // Displays the contents of the Array.
            Console.WriteLine("The Array contains the following values:");
            PrintValues(myArr);




        }



        void PrintValues(Array myArray)
        {
            System.Collections.IEnumerator myEnumerator = myArray.GetEnumerator();
            int i = 0;
            int cols = myArray.GetLength(myArray.Rank - 1);
            while (myEnumerator.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}", myEnumerator.Current);
            }
            Console.WriteLine();
        }

        // This code produces the following output.

        // The Array has 3 dimension(s) and a total of 24 elements.
        //     Length    Lower    Upper
        // 0:  2    0    1
        // 1:  3    0    2
        // 2:  4    0    3
        //

        // The Array contains the following values:
        //    0      1      2      3
        //    10     11     12     13
        //    20     21     22     23
        //    100    101    102    103
        //    110    111    112    113
        //    120    121    122    123

        //PROPERTIES
        public bool IsFixedSize { get; }//Gets a value indicating whether the Array has a fixed size.
        public bool IsReadOnly { get; }//Gets a value indicating whether the Array is read-only.
        public bool IsSynchronized { get; } //Gets a value indicating whether access to the Array is synchronized (thread safe).
        public int Length { get; }//Gets the total number of elements in all the dimensions of the Array.
        public long LongLength { get; }//Gets a 64-bit integer that represents the total number of elements in all the dimensions of the Array.
        public static int MaxLength { get; }//Gets the maximum number of elements that may be contained in an array.
        public int Rank { get; }//Gets the rank (number of dimensions) of the Array. For example, a one-dimensional array returns 1, a two-dimensional array returns 2, and so on.
        public object SyncRoot { get; }//Gets an object that can be used to synchronize access to the Array.

        //METHODS

        //Returns a read-only wrapper for the specified array.
        public static System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly<T>(T[] array);

        //Searches an entire one-dimensional sorted array for a specific element, using the IComparable interface implemented by each element of the array and by the specified object.
        public static int BinarySearch(Array array, object? value);

        //Clears the contents of an array.
        public static void Clear(Array array);

        //Creates a shallow copy of the Array.
        public object Clone();

        //Copies a range of elements from an Array starting at the specified source inde
        public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length);

        //Converts an array of one type to an array of another type.
        public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter);

        //Initializes a new instance of the Array class.
        public static Array CreateInstance(Type elementType, int length);

        //Returns an empty array
        public static T[] Empty<T>();

        ////Determines whether the specified array contains elements that match the conditions defined by the specified predicate.
        public static bool Exists<T>(T[] array, Predicate<T> match);

        //Assigns the given value of type T to each element of the specified array.
        public static void Fill<T>(T[] array, T value);

        //Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire Array.
        public static T? Find<T>(T[] array, Predicate<T> match);

        //Retrieves all the elements that match the conditions defined by the specified predicate.
        public static T[] FindAll<T>(T[] array, Predicate<T> match);

        //Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the entire Array.
        public static int FindIndex<T>(T[] array, Predicate<T> match);

        //Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire Array.
        public static T? FindLast<T>(T[] array, Predicate<T> match);

        //Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the entire Array.
        public static int FindLastIndex<T>(T[] array, Predicate<T> match);

        //Performs the specified action on each element of the specified array.
        public static void ForEach<T>(T[] array, Action<T> action);

        //Returns an IEnumerator for the Array.
        public System.Collections.IEnumerator GetEnumerator();

        //Gets a 32-bit integer that represents the number of elements in the specified dimension of the Array.
        public int GetLength(int dimension);

        //Gets a 64-bit integer that represents the number of elements in the specified dimension of the Array.
        public long GetLongLength(int dimension);


        //Gets the index of the first element of the specified dimension in the array.
        public int GetLowerBound(int dimension);

        //Gets the index of the last element of the specified dimension in the array.
        public int GetUpperBound(int dimension);


        //Gets the value at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.
        public object? GetValue(int index);

        //Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.
        public static int IndexOf(Array array, object? value);


        //Initializes every element of the value-type Array by calling the parameterless constructor of the value type.
        public void Initialize();


        //Searches for the specified object and returns the index of the last occurrence within the entire one-dimensional Array.
        public static int LastIndexOf(Array array, object? value);


        //Changes the number of elements of a one-dimensional array to the specified new size.
        public static void Resize<T>(ref T[]? array, int newSize);

        //Reverses the sequence of the elements in the entire one-dimensional Array.
        public static void Reverse(Array array);


        //Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.
        public void SetValue(object? value, int index);


        //Sorts a range of elements in a pair of one-dimensional Array objects (one contains the keys and the other contains
        //the corresponding items) based on the keys in the first Array using the specified IComparer.
        public static void Sort(Array keys, Array? items, int index, int length, System.Collections.IComparer? comparer);

        //Determines whether every element in the array matches the conditions defined by the specified predicate.
        public static bool TrueForAll<T>(T[] array, Predicate<T> match);


        ///////
        ///EXAMPLES
        public void BinarySearchExample()
        {
            // Creates and initializes a new Array.
            Array myIntArray = Array.CreateInstance(typeof(int), 5);

            myIntArray.SetValue(8, 0);
            myIntArray.SetValue(2, 1);
            myIntArray.SetValue(6, 2);
            myIntArray.SetValue(3, 3);
            myIntArray.SetValue(7, 4);

            // Do the required sort first
            Array.Sort(myIntArray);

            // Displays the values of the Array.
            Console.WriteLine("The int array contains the following:");
            PrintValues(myIntArray);

            // Locates a specific object that does not exist in the Array.
            object myObjectOdd = 1;
            FindMyObject(myIntArray, myObjectOdd);

            // Locates an object that exists in the Array.
            object myObjectEven = 6;
            FindMyObject(myIntArray, myObjectEven);
        }

        public static void FindMyObject(Array myArr, object myObject)
        {
            int myIndex = Array.BinarySearch(myArr, myObject);
            if (myIndex < 0)
            {
                Console.WriteLine("The object to search for ({0}) is not found. The next larger object is at index {1}.", myObject, ~myIndex);
            }
            else
            {
                Console.WriteLine("The object to search for ({0}) is at index {1}.", myObject, myIndex);
            }
        }


        public static void PrintValues(Array myArr)
        {
            int i = 0;
            int cols = myArr.GetLength(myArr.Rank - 1);
            foreach (object o in myArr)
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}", o);
            }
            Console.WriteLine();
            // This code produces the following output.
            //
            //The int array contains the following:
            //        2       3       6       7       8
            //The object to search for (1) is not found. The next larger object is at index 0
            //
            //The object to search for (6) is at index 2.
        }

        public  void BinarySearchExample2()
        {
            string[] dinosaurs = {"Pachycephalosaurus","Amargasaurus","Tyrannosaurus","Mamenchisaurus",
                              "Deinonychus","Edmontosaurus"};

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


        public  void ShowWhere<T>(T[] array, int index)
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
                else
                    Console.Write("{0} and ", array[index - 1]);

                if (index == array.Length)
                    Console.WriteLine("end of array.");
                else
                    Console.WriteLine("{0}.", array[index]);
            }
            else
            {
                Console.WriteLine("Found at index {0}.", index);
            }
        }
        /* This code example produces the following output:

                Pachycephalosaurus
                Amargasaurus
                Tyrannosaurus
                Mamenchisaurus
                Deinonychus
                Edmontosaurus
                        Sort

                Amargasaurus
                Deinonychus
                Edmontosaurus
                Mamenchisaurus
                Pachycephalosaurus
                Tyrannosaurus
                        BinarySearch for 'Coelophysis':
                Not found. Sorts between: Amargasaurus and Deinonychus.

                BinarySearch for 'Tyrannosaurus':
                Found at index 5.
        
                         */


        ////CLEAR
        public void Clear1()
        {
            Console.WriteLine("One dimension (Rank=1):");
            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < 9; i++)
            {
                Console.Write("{0} ", numbers1[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Array.Clear(numbers1, 2, 5)");
            Array.Clear(numbers1, 2, 5); 
            for (int i = 0; i < 9; i++)
            {
                Console.Write("{0} ", numbers1[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Two dimensions (Rank=2):");
            int[,] numbers2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", numbers2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Array.Clear(numbers2, 2, 5)");
            Array.Clear(numbers2, 2, 5);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", numbers2[i, j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Three dimensions (Rank=3):");
            int[,,] numbers3 = {{{1, 2}, {3, 4}},
                             {{5, 6}, {7, 8}},
                             {{9, 10}, {11, 12}}};

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write("{0} ", numbers3[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Array.Clear(numbers3, 2, 5)");
            Array.Clear(numbers3, 2, 5);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write("{0} ", numbers3[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        




    }

    }

}
