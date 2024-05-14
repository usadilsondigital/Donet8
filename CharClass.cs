using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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















        }

    }
}
