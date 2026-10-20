using System.Numerics;
using NumKit;
using Xunit;

namespace NumKit.Tests;

public class FibonacciSequenceTests
{
    [Fact]
    public void SequenceOf0IsEmpty() => Assert.Empty(Fibonacci.Sequence(0));

    [Fact]
    public void SequenceStartsWithTheFirstFibonacciNumbers() =>
        Assert.Equal(new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13 }, Fibonacci.Sequence(8));

    [Fact]
    public void EveryTermMatchesComputeBig()
    {
        var sequence = Fibonacci.Sequence(200);
        Assert.Equal(200, sequence.Length);
        for (int n = 0; n < sequence.Length; n++) Assert.Equal(Fibonacci.ComputeBig(n), sequence[n]);
    }

    [Fact]
    public void SequenceAcceptsTheCapAndRejectsBeyondIt()
    {
        Assert.Equal(10000, Fibonacci.MaxSequenceLength);
        Assert.Equal(10000, Fibonacci.Sequence(10000).Length);
        Assert.Throws<ArgumentOutOfRangeException>(() => Fibonacci.Sequence(10001));
    }

    [Fact]
    public void SequenceValidatesCount() => Assert.Throws<ArgumentOutOfRangeException>(() => Fibonacci.Sequence(-1));

    [Fact]
    public void EveryCallReturnsANewArray()
    {
        var first = Fibonacci.Sequence(5);
        Array.Fill(first, BigInteger.MinusOne);
        Assert.Equal(new BigInteger[] { 0, 1, 1, 2, 3 }, Fibonacci.Sequence(5));
    }
}
