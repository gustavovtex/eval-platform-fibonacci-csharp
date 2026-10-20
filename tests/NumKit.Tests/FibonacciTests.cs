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
}
