using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using MasterMind;

[MemoryDiagnoser]
public class MasterMindBenchmark
{
    private Color[] guessedSequence;
    private Color[] secretSequence;

    [Params(10, 100, 1000)]
    public int SequenceLenght;

    [IterationSetup]
    public void IterationSetup()
    {
        secretSequence = GetRandomColors(SequenceLenght);
        guessedSequence = GetRandomColors(SequenceLenght);
    }


    [Benchmark(Baseline = true)]
    public void SolutionWithDictionaryBenchy()
    {
        SolutionWithDictionary.PlayMastermindRound(secretSequence, guessedSequence);
    }

    [Benchmark]
    public void SolutionWithDynamicListBenchy()
    {
        SolutionWithDynamicListOfIndex.PlayMastermindRound(secretSequence, guessedSequence);
    }

    [Benchmark]
    public void SolutionWithFixedListBenchy()
    {
        SolutionWithFixedListOfIndexes.PlayMastermindRound(secretSequence, guessedSequence);
    }

    private static Color[] GetRandomColors(int sequenceLength)
    {
       return new Random().GetItems(Enum.GetValues(typeof(Color)).Cast<Color>().ToArray(), sequenceLength);
    }

}
