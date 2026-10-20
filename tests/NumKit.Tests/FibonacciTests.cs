using System.Numerics;
using NumKit;
using Xunit;

namespace NumKit.Tests;

public class FibonacciTests
{
    [Fact]
    public void FibonacciOf0And1()
    {
        Assert.Equal(0L, Fibonacci.Compute(0));
        Assert.Equal(1L, Fibonacci.Compute(1));
    }

    [Fact]
    public void TheFirstFibonacciNumbers()
    {
        long[] expected = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
        for (int n = 0; n < expected.Length; n++) Assert.Equal(expected[n], Fibonacci.Compute(n));
    }

    [Fact]
    public void FibonacciOfTheLargestAcceptedInput()
    {
        Assert.Equal(92, Fibonacci.MaxInput);
        Assert.Equal(7540113804746346429L, Fibonacci.Compute(92));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(93)]
    public void FibonacciRejectsOutOfRangeIntegers(int n) =>
        Assert.Throws<ArgumentOutOfRangeException>(() => Fibonacci.Compute(n));

    [Fact]
    public void ComputeBigAgreesWithComputeUpToTheLimit()
    {
        for (int n = 0; n <= Fibonacci.MaxInput; n++) Assert.Equal(new BigInteger(Fibonacci.Compute(n)), Fibonacci.ComputeBig(n));
    }

    [Fact]
    public void ComputeBigGoesBeyondTheLimit()
    {
        Assert.Equal(BigInteger.Parse("14472334024676221"), Fibonacci.ComputeBig(79));
        Assert.Equal(BigInteger.Parse("354224848179261915075"), Fibonacci.ComputeBig(100));
    }

    [Fact]
    public void ComputeBigValidatesInputWithNoUpperBound()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Fibonacci.ComputeBig(-1));
        Assert.True(Fibonacci.ComputeBig(1000) > BigInteger.Zero);
    }
}
