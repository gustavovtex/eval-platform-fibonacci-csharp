namespace NumKit;

public static class Factorial
{
    /// <summary>The largest n whose factorial fits in a long.</summary>
    public const int MaxInput = 20;

    /// <summary>n! for an integer n from 0 to 20 (specs/001-factorial).</summary>
    public static long Compute(int n)
    {
        if (n < 0 || n > MaxInput)
        {
            throw new ArgumentOutOfRangeException(nameof(n), n, $"Factorial expects 0 <= n <= {MaxInput}, got {n}");
        }
        long result = 1;
        for (int i = 2; i <= n; i++) result *= i;
        return result;
    }
}
