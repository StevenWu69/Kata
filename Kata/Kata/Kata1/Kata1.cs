using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kata.Kata1
{
    internal class Kata1
    {
        public static string AverageString(string str)
        {
            var regexItem = new Regex("^[a-z_]*$");

            if (string.IsNullOrEmpty(str) || str.Length == 0 || regexItem.IsMatch(str))
            {
                return "n/a";
            }

            int ans = 0;
            int count = 0;

            string[] digits_list = GetNumString(str);
            var dic = GetDicionary();

            foreach (var digit in digits_list)
            {
                if (dic.ContainsKey(digit))
                {
                    ans += dic[digit];
                    count += 1;
                }
                else
                {
                    return "n/a";
                }
            }

            if (ans != 0)
            {
                int ans_key = Convert.ToInt32(ans / count);
                foreach (KeyValuePair<string, int> digit in dic)
                {
                    string s = digit.Key;
                    int i = digit.Value;
                    if (i == ans_key)
                    {
                        return s;
                    }
                }
            }
            else
            {
                return "zero";
            }

            return "n/a";
        }

        public static string[] GetNumString(string str)
        {
            string[] digitslist = str.Split(' ');

            return digitslist;
        }
        public static Dictionary<string, int> GetDicionary()
        {
            Dictionary<string, int> digits = new Dictionary<string, int>();
            digits.Add("zero", 0);
            digits.Add("one", 1);
            digits.Add("two", 2);
            digits.Add("three", 3);
            digits.Add("four", 4);
            digits.Add("five", 5);
            digits.Add("six", 6);
            digits.Add("seven", 7);
            digits.Add("eight", 8);
            digits.Add("nine", 9);

            return digits;
        }
    }
}