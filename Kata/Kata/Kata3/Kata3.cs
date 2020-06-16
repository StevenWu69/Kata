using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Kata.Kata3
{
    internal class Kata3
    {
        public static string BandNameGenerator(string str)
        {
            var regexItem = new Regex("^[a-zA-Z]*$");

            if (string.IsNullOrEmpty(str) || str[0] == ' ')
            {
                return "invalid input";
            }

            char head = str[0];
            char tail = str[str.Length - 1];

            if (str.Length == 1)
            {
                if (!regexItem.IsMatch(str[0].ToString()))
                {
                    return "The " + str;
                }
                return "The " + str.ToUpper();
            }

            if (head == tail)
            {
                if (!regexItem.IsMatch(str[0].ToString()))
                {
                    return str + str.Remove(0, 1);
                }
                return str[0].ToString().ToUpper() + str.Remove(0, 1) + str.Remove(0, 1);
            }

            string UpperHeadstr;

            if (!regexItem.IsMatch(str[0].ToString()))
            {
                return "The " + str;
            }

            UpperHeadstr = str[0].ToString().ToUpper() + str.Remove(0,1);

            return "The " + UpperHeadstr;

        }
    }
}
