using FluentAssertions;
using ProjectEulerLibrary;
using Xunit;

namespace ProjectEulerLibraryTest
{
    public class ProblemTwoShould
    {
        [Fact]
        public void Return187WhenAddingEvenNumberOfFirstTenNumberOfFibonacciSequence()
            => ProblemTwo.GetSumOfEvenValuesOfFibonacciSequenceFromOneTo(89).Should().Be(187);
    }
}
