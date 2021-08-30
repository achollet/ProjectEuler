using ProjectEulerLibrary.Extensions;
using System.Linq;

namespace ProjectEulerLibrary
{
    public static class ProblemOne
    {
        // Return the sum of multiple of 3 or 5 from one to one thousand;
        public static int GetSumOfThreeOrFiveMultilierFromOneTo(int value)
            => Enumerable.Range(1, value)
                         .Where(number => number.IsMultipleOf(3) || number.IsMultipleOf(5))
                         .Sum();
    }
}
