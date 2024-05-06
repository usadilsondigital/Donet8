using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    //Represents an 8-bit unsigned integer.
    public class ByteClass
    {
        /*public readonly struct Byte : IComparable<byte>, IConvertible, IEquatable<byte>, IParsable<byte>, ISpanParsable<byte>, IUtf8SpanParsable<byte>, System.Numerics.IAdditionOperators<byte,byte,byte>, System.Numerics.IAdditiveIdentity<byte,byte>, System.Numerics.IBinaryInteger<byte>, System.Numerics.IBinaryNumber<byte>, System.Numerics.IBitwiseOperators<byte,byte,byte>, System.Numerics.IComparisonOperators<byte,byte,bool>, System.Numerics.IDecrementOperators<byte>, System.Numerics.IDivisionOperators<byte,byte,byte>, System.Numerics.IEqualityOperators<byte,byte,bool>, System.Numerics.IIncrementOperators<byte>, System.Numerics.IMinMaxValue<byte>, System.Numerics.IModulusOperators<byte,byte,byte>, System.Numerics.IMultiplicativeIdentity<byte,byte>, System.Numerics.IMultiplyOperators<byte,byte,byte>, System.Numerics.INumber<byte>, System.Numerics.INumberBase<byte>, System.Numerics.IShiftOperators<byte,int,byte>, System.Numerics.ISubtractionOperators<byte,byte,byte>, System.Numerics.IUnaryNegationOperators<byte,byte>, System.Numerics.IUnaryPlusOperators<byte,byte>, System.Numerics.IUnsignedNumber<byte>*/

        //Represents the largest possible value of a Byte. This field is constant.
        public const byte MaxValue = 255;

        //Represents the smallest possible value of a Byte. This field is constant.
        public const byte MinValue = 0;


        //The following example demonstrates how to use the MaxValue field to screen variable inputs
        //for values that are outside the range of possible byte values.

        public void MinMaxFields(int numberToSet)
        {
            if (numberToSet <= (int)Byte.MaxValue && numberToSet >= (int)Byte.MinValue)
            {
                // You must explicitly convert an integer to a byte.
               Byte MemberByte = (Byte)numberToSet;


                // Displays MemberByte using the ToString() method.

                Console.WriteLine("The MemberByte value is {0}", MemberByte.ToString());

            }
            else
            {
                Console.WriteLine("The value {0} is outside of the range of possible Byte values", numberToSet.ToString());
            }

        }


        ///methods
        //Clamps a value to an inclusive minimum and maximum value.
        public static byte Clamp(byte value, byte min, byte max);


        //Compares this instance to a specified 8-bit unsigned integer and
        //returns an indication of their relative values.

        public int CompareTo(byte value);

        public static void CompareToExample()
        {

            string nl = Environment.NewLine;
            string msg = "{0}The following is the result of using the generic and non-generic{0}" +
                  "versions of the CompareTo method for several base types:{0}";






        }



    }
}
