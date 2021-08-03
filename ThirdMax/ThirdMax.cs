namespace ThirdMax
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ThirdMax
    {
        public int GetThirdMax(int[] numbers)
        {
            const int NUMBERS_MAX_LENGTH = 10000;
            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;

            if (numbers.Length < 1 || numbers.Length > NUMBERS_MAX_LENGTH)
            {
                return 0;
            }

            HashSet<int> numbersUnique = new HashSet<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersUnique.Add(numbers[i]);
            }

            foreach (int current in numbersUnique)
            {
                if (current > first)
                {
                    third = second;
                    second = first;
                    first = current;
                }
                else if (current > second)
                {
                    third = second;
                    second = current;
                }
                else if (current > third)
                {
                    third = current;
                }
            }

            if(numbersUnique.Count < 3)
            {
                return first;
            }

            return third;
        }
    }
}
