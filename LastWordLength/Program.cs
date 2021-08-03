namespace LastWordLength
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("Hello World!"));
        }

        public static int LengthOfLastWord(string s)
        {
            string[] words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 1)
            {
                return 0;
            }

            string lastWord = words[words.Length - 1];
            return lastWord.Length;
        }
    }
}
