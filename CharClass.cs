﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Donet8
{
    //Represents a character as a UTF-16 code unit.
    public class CharClass
    {

        //Represents the largest possible value of a Char. This field is constant.
        public const char MaxValue;

        //Represents the smallest possible value of a Char. This field is constant.
        public const char MinValue;


        public static void Main()
        {
            char chA = 'A';
            char ch1 = '1';
            string str = "test string";
            Console.WriteLine(chA.CompareTo('B'));          //-----------  Output: "-1" (meaning 'A' is 1 less than 'B')
            Console.WriteLine(chA.Equals('A'));             //-----------  Output: "True"
            Console.WriteLine(Char.GetNumericValue(ch1));   //-----------  Output: "1"
            Console.WriteLine(Char.IsControl('\t'));        //-----------  Output: "True"
            Console.WriteLine(Char.IsDigit(ch1));           //-----------  Output: "True"
            Console.WriteLine(Char.IsLetter(','));          //-----------  Output: "False"
            Console.WriteLine(Char.IsLower('u'));           //-----------  Output: "True"
            Console.WriteLine(Char.IsNumber(ch1));          //-----------  Output: "True"
            Console.WriteLine(Char.IsPunctuation('.'));     //-----------  Output: "True"
            Console.WriteLine(Char.IsSeparator(str, 4));    //-----------  Output: "True"
            Console.WriteLine(Char.IsSymbol('+'));          //-----------  Output: "True"
            Console.WriteLine(Char.IsWhiteSpace(str, 4));   //-----------  Output: "True"
            Console.WriteLine(Char.Parse("S"));             //-----------  Output: "S"
            Console.WriteLine(Char.ToLower('M'));           //-----------  Output: "m"
            Console.WriteLine('x'.ToString());              //-----------  Output: "x"




        }


        //Compares this instance to a specified Char object and indicates whether this instance precedes, follows,
        //or appears in the same position in the sort order as the specified Char object.
        public int CompareTo(char value);

        //Converts the specified Unicode code point into a UTF-16 encoded string.
        public static string ConvertFromUtf32(int utf32);

        public  void ConvertFromUtf32Example()
        {
            int letterA = 0x0041;//U+00041 = LATIN CAPITAL LETTER A
            int music = 0x1D161;////U+1D161 = MUSICAL SYMBOL SIXTEENTH NOTE

            string s1;
            string comment = "Create a UTF-16 encoded string from a code point.";
            string comment1b = "Create a code point from a UTF-16 encoded string.";
            string comment2b = "Create a code point from a surrogate pair at a certain position in a string.";
            string comment2c = "Create a code point from a high surrogate and a low surrogate code point.";
            //  Convert code point U+0041 to UTF-16. The UTF-16 equivalent of
            //  U+0041 is a Char with hexadecimal value 0041.
            Console.WriteLine(comment);
            s1 = Char.ConvertFromUtf32(letterA);
            Console.Write("    1a) 0x{0:X} => ", letterA);
            Show(s1);
            Console.WriteLine();
            //  Convert the lone UTF-16 character to a code point.
            Console.WriteLine(comment1b);
            Console.WriteLine();
            // -------------------------------------------------------------------
            //  Convert the code point U+1D161 to UTF-16. The UTF-16 equivalent of
            //  U+1D161 is a surrogate pair with hexadecimal values D834 and DD61.
            Console.WriteLine(comment);
            s1 = Char.ConvertFromUtf32(music);
            Console.Write("    2a) 0x{0:X} => ", music);
            Show(s1);
            Console.WriteLine();
            //  Convert the surrogate pair in the string at index position
            //  zero to a code point.
            Console.WriteLine(comment2b);
            music = Char.ConvertToUtf32(s1, 0);
            Console.Write("    2b) ");
            Show(s1);
            Console.WriteLine(" => 0x{0:X}", music);
            //  Convert the high and low characters in the surrogate pair into a code point.

            Console.WriteLine(comment2c);
            music = Char.ConvertToUtf32(s1[0], s1[1]);
            Console.Write("    2c) ");
            Show(s1);
            Console.WriteLine(" => 0x{0:X}", music);





        }
        private static void Show(string s) {
            for (int x = 0; x < s.Length; x++) { 
                Console.Write("0x{0:X}{1}",
                     (int)s[x],
                      ((x == s.Length - 1) ? String.Empty : ", "));

            }
                
        }
        /*
        This example produces the following results:
        Create a UTF-16 encoded string from a code point.
        1a) 0x41 => 0x41
        Create a code point from a UTF-16 encoded string.
         1b) 0x41 => 0x41

        Create a UTF-16 encoded string from a code point.
        2a) 0x1D161 => 0xD834, 0xDD61
        //Create a code point from a surrogate pair at a certain position in a string.
         2b) 0xD834, 0xDD61 => 0x1D161
        Create a code point from a high surrogate and a low surrogate code point.
         2c) 0xD834, 0xDD61 => 0x1D161




        */

        //Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.
        public  void ConvertToUtf32Example()
        {
            int letterA = 0x0041; // //U+00041 = LATIN CAPITAL LETTER A
            int music = 0x1D161;////U+1D161 = MUSICAL SYMBOL SIXTEENTH NOTE
            string s1;
            string comment = "Create a UTF-16 encoded string from a code point.";
            string comment1b = "Create a code point from a UTF-16 encoded string.";
            string comment2b = "Create a code point from a surrogate pair at a certain position in a string.";
            string comment2c = "Create a code point from a high surrogate and a low surrogate code point.";
            //  Convert code point U+0041 to UTF-16. The UTF-16 equivalent of
            //  U+0041 is a Char with hexadecimal value 0041.
            Console.WriteLine(comment);

            s1 = Char.ConvertFromUtf32(letterA);
            Console.Write("    1a) 0x{0:X} => ", letterA);
            Show(s1);
            Console.WriteLine();
            //  Convert the lone UTF-16 character to a code point.

            Console.WriteLine(comment1b);
            letterA = Char.ConvertToUtf32(s1, 0);
            Console.Write("    1b) ");
            Show(s1);
            Console.WriteLine(" => 0x{0:X}", letterA);

            Console.WriteLine();
            //  Convert the code point U+1D161 to UTF-16. The UTF-16 equivalent of
            //  U+1D161 is a surrogate pair with hexadecimal values D834 and DD61.
            Console.WriteLine(comment);
            s1 = Char.ConvertFromUtf32(music);
            Console.Write("    2a) 0x{0:X} => ", music);
            Show(s1);

            Console.WriteLine();
            //  Convert the surrogate pair in the string at index position
            //  zero to a code point.
            Console.WriteLine(comment2b);
            music = Char.ConvertToUtf32(s1, 0);
            Console.Write("    2b) ");
            Show(s1);
            Console.WriteLine(" => 0x{0:X}", music);
            //  Convert the high and low characters in the surrogate pair into a code point.
            Console.WriteLine(comment2c);
            music = Char.ConvertToUtf32(s1[0], s1[1]);
            Console.Write("    2c) ");
            Show(s1);
            Console.WriteLine(" => 0x{0:X}", music);


        }

        private  void Show(string s) {
            for (int x = 0; x < s.Length; x++)
                Console.Write("0x{0:X}{1}",
                      (int)s[x],
                       ((x == s.Length - 1) ? String.Empty : ", "));
        }
        /*
        This example produces the following results:
        Create a UTF-16 encoded string from a code point.
        1a) 0x41 => 0x41
        Create a code point from a UTF-16 encoded string
        1b) 0x41 => 0x41
        Create a UTF-16 encoded string from a code point
        2a) 0x1D161 => 0xD834, 0xDD61
        Create a code point from a surrogate pair at a certain position in a string.
        2b) 0xD834, 0xDD61 => 0x1D161
        Create a code point from a high surrogate and a low surrogate code point
        2c) 0xD834, 0xDD61 => 0x1D161
         */

        //Converts the specified numeric Unicode character to a double-precision floating point number.
        public double GetNumericValue(char c) {
            string str = "input: 1";
            Console.WriteLine(Char.GetNumericValue('8'));		// Output: "8"
            Console.WriteLine(Char.GetNumericValue(str, 7));	// Output: "1"
            int utf32 = 0x10107; // AEGEAN NUMBER ONE
            string surrogate = Char.ConvertFromUtf32(utf32);
            foreach (var ch in surrogate)
                Console.WriteLine("U+{0:X4}: {1}    ", Convert.ToUInt16(ch),
                      Char.GetNumericValue(ch));
            // The example displays the following output:
            //       U+D800: -1
            //       U+DD07: -1


        }



        // Define a UTF32 value for each character in the
        // Aegean numbering system.
        for (int utf32 = 0x10107; utf32 <= 0x10133; utf32++) {
            string surrogate = Char.ConvertFromUtf32(utf32);
        for (int ctr = 0; ctr<surrogate.Length; ctr++)
             Console.Write("U+{0:X4} at position {1}: {2}     ",
            Convert.ToUInt16(surrogate[ctr]), ctr,
             Char.GetNumericValue(surrogate, ctr));
            Console.WriteLine();
            // The example displays the following output:
            //       U+D800 at position 0: 1     U+DD07 at position 1: -1
            //       U+D800 at position 0: 2     U+DD08 at position 1: -1
            //       U+D800 at position 0: 3     U+DD09 at position 1: -1
            //       U+D800 at position 0: 4     U+DD0A at position 1: -1
            //       U+D800 at position 0: 5     U+DD0B at position 1: -1
            //       U+D800 at position 0: 6     U+DD0C at position 1: -1
            //       U+D800 at position 0: 7     U+DD0D at position 1: -1
            //       U+D800 at position 0: 8     U+DD0E at position 1: -1
            //       U+D800 at position 0: 9     U+DD0F at position 1: -1
            //       U+D800 at position 0: 10     U+DD10 at position 1: -1

            //       U+D800 at position 0: 20     U+DD11 at position 1: -1
            //       U+D800 at position 0: 30     U+DD12 at position 1: -1
            //       U+D800 at position 0: 40     U+DD13 at position 1: -1
            //       U+D800 at position 0: 50     U+DD14 at position 1: -1
            //       U+D800 at position 0: 60     U+DD15 at position 1: -1
            //       U+D800 at position 0: 70     U+DD16 at position 1: -1
            //       U+D800 at position 0: 80     U+DD17 at position 1: -1
            //       U+D800 at position 0: 90     U+DD18 at position 1: -1
            //       U+D800 at position 0: 100     U+DD19 at position 1: -1
            //       U+D800 at position 0: 200     U+DD1A at position 1: -1
            //       U+D800 at position 0: 300     U+DD1B at position 1: -1
            //       U+D800 at position 0: 400     U+DD1C at position 1: -1
            //       U+D800 at position 0: 500     U+DD1D at position 1: -1
            //       U+D800 at position 0: 600     U+DD1E at position 1: -1
            //       U+D800 at position 0: 700     U+DD1F at position 1: -1
            //       U+D800 at position 0: 800     U+DD20 at position 1: -1
            //       U+D800 at position 0: 900     U+DD21 at position 1: -1
            //       U+D800 at position 0: 1000     U+DD22 at position 1: -1
            //       U+D800 at position 0: 2000     U+DD23 at position 1: -1
            //       U+D800 at position 0: 3000     U+DD24 at position 1: -1
            //       U+D800 at position 0: 4000     U+DD25 at position 1: -1
            //       U+D800 at position 0: 5000     U+DD26 at position 1: -1
            //       U+D800 at position 0: 6000     U+DD27 at position 1: -1






    }
}
