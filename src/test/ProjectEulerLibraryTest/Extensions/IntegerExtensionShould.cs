using FluentAssertions;
using ProjectEulerLibrary.Extensions;
using Xunit;

namespace ProjectEulerLibraryTest.Extensions
{
    public class IntegerExtensionShould
    {
        [Theory]
        [InlineData(6, 3)]
        [InlineData(6, 2)]
        [InlineData(15, 5)]
        public void BeMultipleOf(int source, int value)
            => source.IsMultipleOf(value).Should().BeTrue();

        [Theory]
        [InlineData(6, 4)]
        [InlineData(9, 2)]
        [InlineData(15, 9)]
        public void NotBeMultipleOf(int source, int value)
            => source.IsMultipleOf(value).Should().BeFalse();

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(15)]
        public void BeEvenNumber(int source)
            => source.IsEven().Should().BeTrue();

        [Theory]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(12)]
        public void NotBeEvenNumber(int source)
            => source.IsEven().Should().BeFalse();

        [Theory]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(13)]
        [InlineData(29)]
        public void BePrimeNumer(int value)
            => value.IsPrimeNumber().Should().BeTrue();

        [Theory]
        [InlineData(4)]
        [InlineData(18)]
        [InlineData(21)]
        [InlineData(35)]
        public void NotBePrimeNumer(int value)
            => value.IsPrimeNumber().Should().BeFalse();
    }
}
