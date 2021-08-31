using ProjectEulerLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerLibrary
{
    public static class ProblemThree
    {
        //What is the largest prime factor of the number 600851475143 ?
        public static int GetLargestPrimeFactorOf(int number)
            => GetListOfPrimeFactorsDecompositionOf(number).Max();

        private static IEnumerable<int> GetListOfPrimeFactorsDecompositionOf(int number)
        {
            List<int> primeFactors = new();
            int rest = number;

            for (int i = 1; i < (int)Math.Sqrt(number); i++)
            {
                if (i.IsEven() && rest % i == 0)
                {
                    primeFactors.Add(i);
                    rest /= i;
                }
            }

            return primeFactors;
        }
    }
}
