using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this program where we will be finding maximum number using generics");
            Console.WriteLine(MaximumNumbers.MaxIntNumber(786, 60, 212));
            Console.WriteLine(MaximumNumbers.MaxIntNumber(70, 733, 212));
            Console.WriteLine(MaximumNumbers.MaxIntNumber(943, 73, 3312));
        }
    }
}
