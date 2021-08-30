using ProjectEulerLibrary.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerLibrary
{
    public static class ProblemTwo
    {
        //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

        public static int GetSumOfEvenValuesOfFibonacciSequenceFromOneTo(int maxValue)
            => GetFibonacciSequenceTo(maxValue).Where(number => number.IsEven())
                                               .Sum();

        private static IEnumerable<int> GetFibonacciSequenceTo(int maxValue)
        {
            if (maxValue == 0)
                return new List<int> { 0 };

            if (maxValue == 1)
                return new List<int> { 1 };

            List<int> fibonacciSequence = new List<int> { 1, 2 };

            int index1 = -1;
            int index2 = 0;

            int nextValue;
            do
            {
                index1++;
                index2++;

                nextValue = fibonacciSequence[index1] + fibonacciSequence[index2];

                if (nextValue <= maxValue)
                    fibonacciSequence.Add(nextValue);
            }
            while (nextValue <= maxValue);

            return fibonacciSequence;
        }
    }
}
