using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in this program we finding maximum number using generics");
            Console.WriteLine(MaximumNumbers.MaxIntNumber(786, 60, 212));
            Console.WriteLine(MaximumNumbers.MaxIntNumber(70, 733, 212));
            Console.WriteLine(MaximumNumbers.MaxIntNumber(943, 73, 3312));
            Console.WriteLine(MaximumNumbers.MaxFloatNumber(7.6f, 6.5f, 2.2f));
            Console.WriteLine(MaximumNumbers.MaxFloatNumber(7.6f, 66.5f, 3f));
            Console.WriteLine(MaximumNumbers.MaxFloatNumber(7.46f, 65.5f, 231.2f));

        }
    }
}
