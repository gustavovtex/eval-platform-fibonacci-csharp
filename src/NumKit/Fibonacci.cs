namespace NumKit;

public static class Fibonacci
{
    /// <summary>The largest n whose Fibonacci number fits in a long.</summary>
    public const int MaxInput = 92;

    /// <summary>F(n) for an integer n from 0 to 92 (specs/002-fibonacci), computed iteratively in O(n).</summary>
    public static long Compute(int n)
    {
        if (n == 0) return 0;
        long previous = 0, current = 1;
        for (int i = 1; i < n; i++) (previous, current) = (current, previous + current);
        return current;
    }
}
