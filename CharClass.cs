using System;
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

        public void ConvertFromUtf32Example()
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
        private static void Show(string s)
        {
            for (int x = 0; x < s.Length; x++)
            {
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
        public void ConvertToUtf32Example()
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

        private void Show(string s)
        {
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
        public double GetNumericValue(char c)
        {
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
            //       U+D800 at position 0: 7000     U+DD28 at position 1: -1
            //       U+D800 at position 0: 8000     U+DD29 at position 1: -1
            //       U+D800 at position 0: 9000     U+DD2A at position 1: -1
            //       U+D800 at position 0: 10000     U+DD2B at position 1: -1
            //       U+D800 at position 0: 20000     U+DD2C at position 1: -1
            //       U+D800 at position 0: 30000     U+DD2D at position 1: -1



            //Returns true if c is an ASCII character ([ U+0000..U+007F ]).
            public static bool IsAscii(char c);


        //Indicates whether a character is categorized as an ASCII digit.
        public static bool IsAsciiDigit(char c);


        //Indicates whether a character is categorized as an ASCII hexademical digit.
        public static bool IsAsciiHexDigit(char c);


        //Indicates whether a character is categorized as an ASCII lower-case hexademical digit.
        public static bool IsAsciiHexDigitLower(char c);



        //Indicates whether a character is categorized as an ASCII upper-case hexademical digit.
        public static bool IsAsciiHexDigitUpper(char c);



        //Indicates whether a character is categorized as an ASCII letter.
        public static bool IsAsciiLetter(char c);


        //Indicates whether a character is categorized as a lowercase ASCII letter.
        public static bool IsAsciiLetterLower(char c);



        //Indicates whether a character is categorized as an ASCII letter or digit.
        public static bool IsAsciiLetterOrDigit(char c);


        //Indicates whether a character is categorized as an uppercase ASCII letter.
        public static bool IsAsciiLetterUpper(char c);


        //Indicates whether a character is within the specified inclusive range.
        public static bool IsBetween(char c, char minInclusive, char maxInclusive);



        //Indicates whether the specified Unicode character is categorized as a control character.
        public static bool IsControl(char c);



        public void IsDigitSample()
        {
            char ch = '8';
            Console.WriteLine(Char.IsDigit(ch));                    // Output: "True"
            Console.WriteLine(Char.IsDigit("sample string", 7));	// Output: "False"
        }

        // This example demonstrates the Char.IsLowSurrogate() method
        //                                    IsHighSurrogate() method
        //                                    IsSurrogatePair() method
        public void IsHighSurrogateExample()
        {
            char cHigh = '\uD800';
            char cLow = '\uDC00';
            string s1 = new String(new char[] { 'a', '\uD800', '\uDC00', 'z' });
            string divider = String.Concat(Environment.NewLine, new String('-', 70), Environment.NewLine);
            Console.WriteLine();
            Console.WriteLine("Hexadecimal code point of the character, cHigh: {0:X4}", (int)cHigh);
            Console.WriteLine("Hexadecimal code point of the character, cLow:  {0:X4}", (int)cLow);
            Console.WriteLine();
            Console.WriteLine("Characters in string, s1: 'a', high surrogate, low surrogate, 'z'");
            Console.WriteLine("Hexadecimal code points of the characters in string, s1: ");

            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine("s1[{0}] = {1:X4} ", i, (int)s1[i]);
            }
            Console.WriteLine(divider);
            Console.WriteLine("Is each of the following characters a high surrogate?");
            Console.WriteLine("A1) cLow?  - {0}", Char.IsHighSurrogate(cLow));
            Console.WriteLine("A2) cHigh? - {0}", Char.IsHighSurrogate(cHigh));
            Console.WriteLine("A3) s1[0]? - {0}", Char.IsHighSurrogate(s1, 0));
            Console.WriteLine("A4) s1[1]? - {0}", Char.IsHighSurrogate(s1, 1));
            Console.WriteLine(divider);
            Console.WriteLine("Is each of the following characters a low surrogate?");
            Console.WriteLine("B1) cLow?  - {0}", Char.IsLowSurrogate(cLow));
            Console.WriteLine("B2) cHigh? - {0}", Char.IsLowSurrogate(cHigh));
            Console.WriteLine("B3) s1[0]? - {0}", Char.IsLowSurrogate(s1, 0));
            Console.WriteLine("B4) s1[2]? - {0}", Char.IsLowSurrogate(s1, 2));
            Console.WriteLine(divider);
            Console.WriteLine("Is each of the following pairs of characters a surrogate pair?");
            Console.WriteLine("C1) cHigh and cLow?  - {0}", Char.IsSurrogatePair(cHigh, cLow));
            Console.WriteLine("C2) s1[0] and s1[1]? - {0}", Char.IsSurrogatePair(s1, 0));
            Console.WriteLine("C3) s1[1] and s1[2]? - {0}", Char.IsSurrogatePair(s1, 1));
            Console.WriteLine("C4) s1[2] and s1[3]? - {0}", Char.IsSurrogatePair(s1, 2));
            Console.WriteLine(divider);
            /*
This example produces the following results:
            Hexadecimal code point of the character, cHigh: D800
            Hexadecimal code point of the character, cLow:  DC00

            Characters in string, s1: 'a', high surrogate, low surrogate, 'z'
            Hexadecimal code points of the characters in string, s1:
            s1[0] = 0061
            s1[1] = D800
            s1[2] = DC00
            s1[3] = 007A
            ----------------------------------------------------------------------
            Is each of the following characters a high surrogate?

            A1) cLow?  - False
            A2) cHigh? - True
            A3) s1[0]? - False
            A4) s1[1]? - True
            ----------------------------------------------------------------------
            Is each of the following characters a low surrogate?
            B1) cLow?  - True
            B2) cHigh? - False
            B3) s1[0]? - False
            B4) s1[2]? - True
            ----------------------------------------------------------------------
            Is each of the following pairs of characters a surrogate pair?
            C1) cHigh and cLow?  - True
            C2) s1[0] and s1[1]? - False
            C3) s1[1] and s1[2]? - True
            C4) s1[2] and s1[3]? - False



             */





        }


        public void IsLetterSample()
        {

            char ch = '8';
            Console.WriteLine(Char.IsLetter(ch));                   // False

            Console.WriteLine(Char.IsLetter("sample string", 7));   // True
        }

        public void IsLetterOrDigitSample
        {
            string str = "newline:\n";
            Console.WriteLine(Char.IsLetterOrDigit('8'));       // Output: "True"
            Console.WriteLine(Char.IsLetterOrDigit(str, 8));    // Output: "False", because it's a newline          
          
        }
    
        public  void IsLowerSample()
        {
            char ch = 'a';
            Console.WriteLine(Char.IsLower(ch));                // Output: "True"
        Console.WriteLine(Char.IsLower("upperCase", 5));    // Output: "False"
        }


    public  void IsLowSurrogate()
    {
        char cHigh = '\uD800';
        char cLow = '\uDC00';
        string s1 = new String(new char[] { 'a', '\uD800', '\uDC00', 'z' });
        string divider = String.Concat(Environment.NewLine, new String('-', 70),
                                    Environment.NewLine);
        Console.WriteLine();
        Console.WriteLine("Hexadecimal code point of the character, cHigh: {0:X4}", (int)cHigh);
        Console.WriteLine("Hexadecimal code point of the character, cLow:  {0:X4}", (int)cLow);
        Console.WriteLine();
        Console.WriteLine("Characters in string, s1: 'a', high surrogate, low surrogate, 'z'");
        Console.WriteLine("Hexadecimal code points of the characters in string, s1: ");
        for (int i = 0; i < s1.Length; i++)
        {
            Console.WriteLine("s1[{0}] = {1:X4} ", i, (int)s1[i]);
        }
        Console.WriteLine(divider);
        Console.WriteLine("Is each of the following characters a high surrogate?");
        Console.WriteLine("A1) cLow?  - {0}", Char.IsHighSurrogate(cLow));
        Console.WriteLine("A2) cHigh? - {0}", Char.IsHighSurrogate(cHigh));
        Console.WriteLine("A3) s1[0]? - {0}", Char.IsHighSurrogate(s1, 0));
        Console.WriteLine("A4) s1[1]? - {0}", Char.IsHighSurrogate(s1, 1));
        Console.WriteLine(divider);
        Console.WriteLine("Is each of the following characters a low surrogate?");
        Console.WriteLine("B1) cLow?  - {0}", Char.IsLowSurrogate(cLow));
        Console.WriteLine("B2) cHigh? - {0}", Char.IsLowSurrogate(cHigh));




    }




}
}
