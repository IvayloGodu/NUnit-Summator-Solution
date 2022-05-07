using System;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            long sum = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 9, });
            if (sum == 24)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }

            double averege = Summator.Averege(new double[] { 5, 10, });
            if (averege == 7.5)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }
        }
    }
}





