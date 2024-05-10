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

            DateTime now = DateTime.Now;
            // Time span = 11 days, 22 hours, 33 minutes, 44 seconds
            TimeSpan tsX = new TimeSpan(11, 22, 33, 44);
            // Version = 1.2.333.4
            Version versX = new Version("1.2.333.4");

            // Guid = CA761232-ED42-11CE-BACD-00AA0057B223
            Guid guidX = new Guid("{CA761232-ED42-11CE-BACD-00AA0057B223}");
            try
            {
                Boolean a1 = true, a2 = true;
                Byte b1 = 1, b2 = 1;
                Int16 c1 = -2, c2 = 2;
                Int32 d1 = 3, d2 = 3;
                Int64 e1 = 4, e2 = -4;
                Decimal f1 = -5.5m, f2 = 5.5m;
                Single g1 = 6.6f, g2 = 6.6f;
                Double h1 = 7.7d, h2 = -7.7d;
                Char i1 = 'A', i2 = 'A';
                String j1 = "abc", j2 = "abc";
                DateTime k1 = now, k2 = now;
                TimeSpan l1 = tsX, l2 = tsX;
                Version m1 = versX, m2 = new Version("2.0");
                Guid n1 = guidX, n2 = guidX;

                // The following types are not CLS-compliant.
                SByte w1 = 8, w2 = 8;
                UInt16 x1 = 9, x2 = 9;
                UInt32 y1 = 10, y2 = 10;
                UInt64 z1 = 11, z2 = 11;
                //
                Console.WriteLine(msg, nl);

                // The second and third Show method call parameters are automatically boxed because
                //the second and third Show method declaration arguments expect type Object.
                Show("Boolean:  ", a1, a2, a1.CompareTo(a2), a1.CompareTo((Object)a2));
                Show("Byte:     ", b1, b2, b1.CompareTo(b2), b1.CompareTo((Object)b2));
                Show("Int16:    ", c1, c2, c1.CompareTo(c2), c1.CompareTo((Object)c2));
                Show("Int32:    ", d1, d2, d1.CompareTo(d2), d1.CompareTo((Object)d2));
                Show("Int64:    ", e1, e2, e1.CompareTo(e2), e1.CompareTo((Object)e2));
                Show("Decimal:  ", f1, f2, f1.CompareTo(f2), f1.CompareTo((Object)f2));
                Show("Single:   ", g1, g2, g1.CompareTo(g2), g1.CompareTo((Object)g2));
                Show("Double:   ", h1, h2, h1.CompareTo(h2), h1.CompareTo((Object)h2));
                Show("Char:     ", i1, i2, i1.CompareTo(i2), i1.CompareTo((Object)i2));
                Show("String:   ", j1, j2, j1.CompareTo(j2), j1.CompareTo((Object)j2));
                Show("DateTime: ", k1, k2, k1.CompareTo(k2), k1.CompareTo((Object)k2));
                Show("TimeSpan: ", l1, l2, l1.CompareTo(l2), l1.CompareTo((Object)l2));
                Show("Version:  ", m1, m2, m1.CompareTo(m2), m1.CompareTo((Object)m2));
                Show("Guid:     ", n1, n2, n1.CompareTo(n2), n1.CompareTo((Object)n2));
                //
                Console.WriteLine("{0}The following types are not CLS-compliant:", nl);
                Show("SByte:    ", w1, w2, w1.CompareTo(w2), w1.CompareTo((Object)w2));
                Show("UInt16:   ", x1, x2, x1.CompareTo(x2), x1.CompareTo((Object)x2));
                Show("UInt32:   ", y1, y2, y1.CompareTo(y2), y1.CompareTo((Object)y2));
                Show("UInt64:   ", z1, z2, z1.CompareTo(z2), z1.CompareTo((Object)z2));
            }
            catch (Exception e) { Console.WriteLine(e); }


        }
        public static void Show(string caption, Object var1, Object var2,
                           int resultGeneric, int resultNonGeneric)
        { 
            string relation;
            Console.Write(caption);
            if (resultGeneric == resultNonGeneric)
            {
                if (resultGeneric < 0) relation = "less than";
                else if (resultGeneric > 0) relation = "greater than";
                else relation = "equal to";
                Console.WriteLine("{0} is {1} {2}", var1, relation, var2);


            }
            // The following condition will never occur because the generic and non-generic
            // CompareTo methods are equivalent.
            else
            {
                Console.WriteLine("Generic CompareTo = {0}; non-generic CompareTo = {1}",
                     resultGeneric, resultNonGeneric);
            }
        }
        /*This example produces the following results:
         The following is the result of using the generic and non-generic versions of the
        CompareTo method for several base types:
        Boolean:  True is equal to True
         Byte:     1 is equal to 1
        Int16:    -2 is less than 2
        Int32:    3 is equal to 3
        Int64:    4 is greater than -4
        Decimal:  -5.5 is less than 5.5
        Single:   6.6 is equal to 6.6
        Double:   7.7 is greater than -7.7
        Char:     A is equal to A
        String:   abc is equal to abc
        DateTime: 12/1/2003 5:37:46 PM is equal to 12/1/2003 5:37:46 PM
        TimeSpan: 11.22:33:44 is equal to 11.22:33:44
        Version:  1.2.333.4 is less than 2.0
        Guid:     ca761232-ed42-11ce-bacd-00aa0057b223 is equal to ca761232-ed42-11ce-bacd-00
aa0057b223

        The following types are not CLS-compliant:
        SByte:    8 is equal to 8
        UInt16:   9 is equal to 9
        UInt32:   10 is equal to 10
        UInt64:   11 is equal to 11




         */


        //Copies the sign of a value to the sign of another value.
        public static sbyte CopySign(sbyte value, sbyte sign);

        //Creates an instance of the current type from a value, throwing an overflow exception for any values that
        //fall outside the representable range of the current type.
        public static sbyte CreateChecked<TOther>(TOther value) where TOther : System.Numerics.INumberBase<TOther>;




        //Creates an instance of the current type from a value,
        //saturating any values that fall outside the representable range of the current type.
        public static sbyte CreateSaturating<TOther>(TOther value) where TOther : System.Numerics.INumberBase<TOther>;


        //Creates an instance of the current type from a value, truncating any values that fall outside the representable range of the current type.
        public static sbyte CreateTruncating<TOther>(TOther value) where TOther : System.Numerics.INumberBase<TOther>;

        //Computes the quotient and remainder of two values.
        public static (sbyte Quotient, sbyte Remainder) DivRem(sbyte left, sbyte right);

        //Returns a value indicating whether this instance is equal to a specified object.
        public override bool Equals(object? obj);

        //Returns the hash code for this instance.
        public override int GetHashCode();

        //Returns the TypeCode for value type SByte.
        public TypeCode GetTypeCode();

        //Determines if a value represents an even integral number.
        public static bool IsEvenInteger(sbyte value);


        //Determines if a value is negative.
        public static bool IsNegative(sbyte value);

        //Determines if a value represents an odd integral number.
        public static bool IsOddInteger(sbyte value);

        //Determines if a value is positive.
        public static bool IsPositive(sbyte value);

        //Determines if a value is a power of two.
        public static bool IsPow2(sbyte value);

        /// <summary>
        /// Computes the number of leading zeros in a value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static sbyte LeadingZeroCount(sbyte value);

        //Computes the log2 of a value.
        public static sbyte Log2(sbyte value);


        //Compares two values to compute which is greater.
        public static sbyte Max(sbyte x, sbyte y);

        public static sbyte MaxMagnitude(sbyte x, sbyte y);




    }
}



























