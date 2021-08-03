namespace IsPalindrome
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
            isPalindrome("A man, a plan, a canal: Panama");
        }

        public static bool isPalindrome(string s)
        {
            string inputSanitized = sanitizeInput(s);

            //return iterative(inputSanitized);
            return recursive(inputSanitized);
        }

        private static string sanitizeInput(string s)
        {
            Regex rgx = new Regex("[^a-z0-9]");
            s = s.ToLower();
            return rgx.Replace(s, "");
        }

        private static bool recursive(string s)
        {
            int length = s.Length;
            if (length <= 1)
            {
                return true;
            }

            if(s[0] == s[length-1])
            {
                return recursive(s.Substring(1, length - 2));
            }
            else
            {
                return false;
            }
        }

        private static bool iterative(string s)
        {
            for (int i = 0, j = s.Length; i < j; i++, j--)
            {
                if (s[i] != s[j - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
