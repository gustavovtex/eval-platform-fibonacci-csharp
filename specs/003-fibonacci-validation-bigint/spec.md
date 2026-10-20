# 003 — fibonacci: input validation and BigInteger

## Goal

Make `Fibonacci.Compute(n)` refuse bad input the same way `Factorial.Compute(n)` does, and add
`Fibonacci.ComputeBig(n)` for Fibonacci numbers beyond F(92).

## Requirements

1. `Fibonacci.Compute(n)` keeps its behavior for integers from 0 to 92, and now throws
   `ArgumentOutOfRangeException` when `n` is below 0 or above 92.
2. `Fibonacci.ComputeBig(int n)` is a public static method of `NumKit.Fibonacci` and returns
   `F(n)` as a `System.Numerics.BigInteger` for any integer `n >= 0`.
3. `Fibonacci.ComputeBig(n)` throws `ArgumentOutOfRangeException` when `n` is below 0. There is
   no upper bound.
4. For every `n` from 0 to 92, `Fibonacci.ComputeBig(n) == Fibonacci.Compute(n)`.
5. Both methods stay iterative and O(n).
6. `README.md` lists this spec and shows `Fibonacci.ComputeBig` in the usage example.
