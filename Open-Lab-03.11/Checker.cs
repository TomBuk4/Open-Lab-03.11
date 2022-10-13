using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string first = str.Substring(0, str.Length / 2);
            char[] a = str.ToCharArray();

            Array.Reverse(a);

            string reverse = new string(a);
            string second = reverse.Substring(0, reverse.Length / 2);

            return str == reverse;
        }
    }
}
