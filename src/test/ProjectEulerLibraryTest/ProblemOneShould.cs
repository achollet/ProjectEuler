using FluentAssertions;
using ProjectEulerLibrary;
using Xunit;

namespace ProjectEulerLibraryTest
{
    public class ProblemOneShould
    {
        [Fact]
        public void Return23WhenAddingMultiplesOf3Or5Below10()
            => ProblemOne.GetSumOfThreeOrFiveMultilierFromOneTo(10).Should().Be(23);
    }
}
