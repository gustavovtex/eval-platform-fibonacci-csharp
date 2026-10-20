# 001 — factorial

## Goal

Provide `Factorial.Compute(n)`, the product of all positive integers up to `n`.

## Requirements

1. `Factorial.Compute(int n)` is a public static method of `NumKit.Factorial`, in
   `src/NumKit/Factorial.cs`, and returns a `long`.
2. `Factorial.Compute(0)` is `1`.
3. For an integer `n` from 1 to 20, `Factorial.Compute(n)` returns `n!`. 20! is the largest
   factorial that fits in a `long`.
4. Any other input throws `ArgumentOutOfRangeException`: `n` below 0 or above 20.

## Out of scope

Factorials above 20 (they need `BigInteger`).
