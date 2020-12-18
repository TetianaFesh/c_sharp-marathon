using System;

namespace Sprint7
{
    class Program
    {
        public static double EvaluateSumOfElementsOddPositions(double[] inputData)
        {
            double result = 0;
            for (int i = 1; i < inputData.Length; i += 2)
            {
                result += inputData[i];
            }
            return result;
        }
        //static void Main(string[] args)
        //{
        //    double[] array = new double[] { 1, 2, 3, 4, 5, 6};
        //    double result = EvaluateSumOfElementsOddPositions(array);
        //    Console.WriteLine(result);
        //}
    }
}
