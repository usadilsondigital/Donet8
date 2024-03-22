using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet8
{
    public class StringSearcher
    {
        char firstChar;

        public StringSearcher(char firstChar)
        {
            this.firstChar = char.ToUpper(firstChar);
        }

        public bool StartsWith(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;

            if (s.Substring(0, 1).ToUpper() == firstChar.ToString())
                return true;
            else
                return false;
        }


    }
