# 002 — fibonacci

## Goal

Provide `Fibonacci.Compute(n)`, the n-th Fibonacci number, with `F(0) = 0`, `F(1) = 1` and
`F(n) = F(n - 1) + F(n - 2)`.

## Requirements

1. `Fibonacci.Compute(int n)` is a public static method of `NumKit.Fibonacci`, in
   `src/NumKit/Fibonacci.cs`, and returns a `long`.
2. For an integer `n` from 0 to 92, `Fibonacci.Compute(n)` returns `F(n)`. F(92) is the largest
   Fibonacci number that fits in a `long`.
3. The computation is iterative and runs in O(n) time: no recursion, no exponential blow-up.
4. `README.md` lists the new method in its specs table and shows a usage example.

## Out of scope

Input validation and values above F(92). They come in a later spec.
