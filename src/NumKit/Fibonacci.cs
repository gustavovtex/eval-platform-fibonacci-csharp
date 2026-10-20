using System.Numerics;

namespace NumKit;

public static class Fibonacci
{
    /// <summary>The longest sequence Sequence builds (specs/004-fibonacci-sequence).</summary>
    public const int MaxSequenceLength = 10000;

    /// <summary>The largest n whose Fibonacci number fits in a long.</summary>
    public const int MaxInput = 92;

    private static void CheckNonNegative(string name, int n)
    {
        if (n < 0) throw new ArgumentOutOfRangeException(nameof(n), n, $"{name} expects n >= 0, got {n}");
    }

    /// <summary>F(n) for an integer n from 0 to 92 (specs/002-fibonacci, 003), computed iteratively in O(n).</summary>
    public static long Compute(int n)
    {
        CheckNonNegative("Compute", n);
        if (n > MaxInput)
        {
            throw new ArgumentOutOfRangeException(nameof(n), n, $"Compute expects n <= {MaxInput}, got {n}; use ComputeBig");
        }
        if (n == 0) return 0;
        long previous = 0, current = 1;
        for (int i = 1; i < n; i++) (previous, current) = (current, previous + current);
        return current;
    }

    /// <summary>F(n) for any integer n >= 0 (specs/003-fibonacci-validation-bigint), iterative, O(n).</summary>
    public static BigInteger ComputeBig(int n)
    {
        CheckNonNegative("ComputeBig", n);
        if (n == 0) return BigInteger.Zero;
        BigInteger previous = BigInteger.Zero, current = BigInteger.One;
        for (int i = 1; i < n; i++) (previous, current) = (current, previous + current);
        return current;
    }

    /// <summary>[F(0), ..., F(count - 1)], built in one pass (specs/004-fibonacci-sequence). Every call returns a new array.</summary>
    public static BigInteger[] Sequence(int count)
    {
        CheckNonNegative("Sequence", count);
        if (count > MaxSequenceLength)
        {
            throw new ArgumentOutOfRangeException(nameof(count), count, $"Sequence expects count <= {MaxSequenceLength}, got {count}");
        }
        var sequence = new BigInteger[count];
        BigInteger previous = BigInteger.Zero, current = BigInteger.One;
        for (int i = 0; i < count; i++)
        {
            sequence[i] = previous;
            (previous, current) = (current, previous + current);
        }
        return sequence;
    }
}
