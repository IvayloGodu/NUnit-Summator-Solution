
namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        public static double Averege(double[] arr)
        {
            double averege = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                averege = averege + arr[i];
            }
            return averege/arr.Length;
        }      
    }
}
