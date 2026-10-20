using NumKit;
using Xunit;

namespace NumKit.Tests;

public class FactorialTests
{
    [Theory]
    [InlineData(0, 1L)]
    [InlineData(1, 1L)]
    [InlineData(5, 120L)]
    [InlineData(10, 3628800L)]
    public void FactorialOfSmallIntegers(int n, long expected) => Assert.Equal(expected, Factorial.Compute(n));

    [Fact]
    public void FactorialOfTheLargestAcceptedInput()
    {
        Assert.Equal(20, Factorial.MaxInput);
        Assert.Equal(2432902008176640000L, Factorial.Compute(20));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(21)]
    public void FactorialRejectsOutOfRangeIntegers(int n) =>
        Assert.Throws<ArgumentOutOfRangeException>(() => Factorial.Compute(n));
}
