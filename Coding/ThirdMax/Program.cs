namespace ThirdMax
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            ThirdMax thirdMax = new ThirdMax();
            Console.WriteLine(thirdMax.GetThirdMax(new int[] { 3, 2, 1 })); // 1
            Console.WriteLine(thirdMax.GetThirdMax(new int[] { 1, 2 })); // 2
            Console.WriteLine(thirdMax.GetThirdMax(new int[] { 2, 2, 3, 1 })); // 1
        }
    }
}
