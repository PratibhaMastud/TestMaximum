using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome To Maximum Number Problem");
                int[] Output = { 11, 22, 50 };
                MaximumNumbers<int> maximumNumbers = new MaximumNumbers<int>(Output);
                maximumNumbers.PrintValue();
            }
        }
    }
}

