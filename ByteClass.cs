﻿using System;
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



        }



    }
}



























