using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class ExmapleGetEnumerator
    {
        public  void example()
        {

            // Creates and initializes a new Array.
            String[] myArr = new String[10];
            myArr[0] = "The";
            myArr[1] = "quick";
            myArr[2] = "brown";
            myArr[3] = "fox";
            myArr[4] = "jumps";
            myArr[5] = "over";
            myArr[6] = "the";
            myArr[7] = "lazy";
            myArr[8] = "dog";

            // Displays the values of the Array.
            int i = 0;
            System.Collections.IEnumerator myEnumerator = myArr.GetEnumerator();

        }




    }
}
