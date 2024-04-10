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





        }





    }
}
