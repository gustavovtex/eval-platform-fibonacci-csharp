# 004 — fibonacci sequence

## Goal

Provide `Fibonacci.Sequence(count)`, the first `count` Fibonacci numbers, for callers that need
the whole sequence instead of a single term.

## Requirements

1. `Fibonacci.Sequence(int count)` is a public static method of `NumKit.Fibonacci` and returns a
   `BigInteger[]` of `count` values: `[F(0), F(1), ..., F(count - 1)]`. `Fibonacci.Sequence(0)` is
   an empty array.
2. `count` is validated like `Fibonacci.ComputeBig(n)`: `ArgumentOutOfRangeException` when it is
   below 0. It is also capped: the same exception when it is above 10000.
3. The sequence is built in a single pass, O(count). Calling `Fibonacci.ComputeBig` once per term
   (O(count²)) does not meet this requirement.
4. Every call returns a new array. A caller may sort, fill or truncate the array it received, and
   no later call returns a different result because of it. In particular, a static cache, if one
   is used, is never handed to the caller.
5. `Fibonacci.Sequence(10000)` completes in under 100 ms on a current laptop.
6. `README.md` lists this spec and shows `Fibonacci.Sequence` in the usage example.
