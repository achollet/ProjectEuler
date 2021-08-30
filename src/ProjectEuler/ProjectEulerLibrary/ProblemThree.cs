using ProjectEulerLibrary.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerLibrary
{
    public static class ProblemThree
    {
        //What is the largest prime factor of the number 600851475143 ?
        public static int GetLargestPrimeFactorOf(int number)
            => GetListOfPrimeFactorsOf(number).Max();

        private static IEnumerable<int> GetListOfPrimeFactorsOf(int number)
            => Enumerable.Range(1, number).Where(x => x == 1 || x.IsPrimeNumber());
    }
}
