using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class BooleanClass
    {
        //Boolean.CompareTo
        //Compares this instance to a specified
        //object or Boolean object and returns an integer that indicates their relationship to one another.

        public  void example()
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

            Console.WriteLine(msg, nl);





        }





    }
}
