using System;
using BenchmarkDotNet.Attributes;

namespace Fare.Benchmarking;

public class Benchmark
{
    private readonly Random random = new ();

    [Benchmark]
    public Xeger XegerCtorSimple() => new (".");

    [Benchmark]
    public Xeger XegerCtorInjectRandom() => new (".", this.random);
}
