using FluentAssertions;
using ProjectEulerLibrary;
using Xunit;

namespace ProjectEulerLibraryTest
{
    public class ProblemThreeShould
    {
        [Fact]
        public void Return29AsTheLargestPrimeFactorOf13195()
            => ProblemThree.GetLargestPrimeFactorOf(13195).Should().Be(29);
    }
}
