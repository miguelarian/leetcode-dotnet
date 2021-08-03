namespace FizzBuzz
{
    using System.Collections.Generic;

    public class FizzBuzz
    {
        private static readonly int MAX_INPUT = 10000;

        public IList<string> Run(int n)
        {
            
            string[] answer = new string[n];

            if (n <= 0 || n > MAX_INPUT)
            {
                return new string[0];
            }

            for (int i = 0; i < n; i++)
            {
                int value = i + 1;

                if(value % 3 == 0 &&
                   value % 5 == 0)
                {
                    answer[i] = "FizzBuzz";
                }
                else if (value % 3 == 0)
                {
                    answer[i] = "Fizz";
                }
                else if (value % 5 == 0)
                {
                    answer[i] = "Buzz";
                }
                else
                {
                    answer[i] = value.ToString();
                }
            }

            return answer;
        }
    }
}
