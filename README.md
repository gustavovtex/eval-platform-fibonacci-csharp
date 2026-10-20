# eval-platform-fibonacci-csharp

Small number utilities in plain C#, with no dependencies.

This repository is a fixture for the [eval platform](https://github.com/vtex/eval-platform): its
pull requests are small, each one carries its own spec under `specs/`, and the whole test suite
runs in under a second. That makes it a cheap way to check that an evaluation works end to end,
locally and in production. It is not meant to tell models apart: the tasks are too easy for that.

Twin repositories have the same history in other languages: `eval-platform-fibonacci-node`, `eval-platform-fibonacci-python`, `eval-platform-fibonacci-go`, `eval-platform-fibonacci-rust`.

## Usage

```csharp
using NumKit;

Factorial.Compute(5); // 120
Fibonacci.Compute(10); // 55
Fibonacci.ComputeBig(100); // 354224848179261915075
Fibonacci.Sequence(5); // [0, 1, 1, 2, 3]
```

## Tests

```sh
dotnet test tests/NumKit.Tests
```

.NET 8 SDK or newer. The tests use xUnit, restored from NuGet on the first run; the library itself has no dependencies.

## Specs

Every change starts with a spec in `specs/NNN-name/spec.md`.

| Spec | Feature |
|---|---|
| [001-factorial](specs/001-factorial/spec.md) | `Factorial.Compute(n)` |
| [002-fibonacci](specs/002-fibonacci/spec.md) | `Fibonacci.Compute(n)` |
| [003-fibonacci-validation-bigint](specs/003-fibonacci-validation-bigint/spec.md) | input validation, `Fibonacci.ComputeBig(n)` |
| [004-fibonacci-sequence](specs/004-fibonacci-sequence/spec.md) | `Fibonacci.Sequence(count)` |
