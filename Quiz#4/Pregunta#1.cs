using System;
using System.Collections.Generic;

public static class IntervalMerger
{
    public static List<int[]> MergeIntervals(List<int[]> intervals)
    {
        if (intervals == null || intervals.Count == 0)
            return new List<int[]>();

        intervals.Sort((a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();
        int[] current = intervals[0];

        foreach (var interval in intervals.GetRange(1, intervals.Count - 1))
        {
            if (interval[0] <= current[1])
            {
                current[1] = Math.Max(current[1], interval[1]);
            }
            else
            {
                merged.Add(current);
                current = interval;
            }
        }
        merged.Add(current);
        return merged;
    }

    public static void PrintIntervals(List<int[]> intervals)
    {
        foreach (var interval in intervals)
        {
            Console.Write($"{{{interval[0]},{interval[1]}}} ");
        }
        Console.WriteLine();
    }
}
