using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class MaximumNumbers<T> where T : IComparable
    {
        public T[] Number;
        public MaximumNumbers(T[] Number)
        {
            this.Number = Number;

        }

        public static T MaxNumber(T firstNumber, T secondNumber, T thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                Console.Write("this is greater");
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            throw new Exception("firstNumber,secondNumber,thirdNumber Same");
        }

        public T[] Sort(T[] Number)
        {
            Array.Sort(Number);
            return Number;
        }

        public T MaximumValue(params T[] Number)
        {
            var SorteNumber = Sort(Number);
            return SorteNumber[^1];
        }

        public T MaxMethod()
        {
            var MaxValue = MaximumValue(this.Number);
            return MaxValue;
        }

        public void PrintValue()
        {
            var max = MaximumValue(this.Number);
            Console.Write(max);

        }
    }
}
