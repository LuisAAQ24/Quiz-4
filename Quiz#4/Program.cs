using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // --- Ejemplo de unir intervalos ---
        var intervals1 = new List<int[]> { new int[] { 1, 6 }, new int[] { 6, 9 }, new int[] { 9, 10 }, new int[] { 2, 4 } };
        var merged1 = IntervalMerger.MergeIntervals(intervals1);
        Console.WriteLine("Intervalos unidos:");
        IntervalMerger.PrintIntervals(merged1);

        var intervals2 = new List<int[]> { new int[] { 6, 8 }, new int[] { 1, 9 }, new int[] { 2, 4 } };
        var merged2 = IntervalMerger.MergeIntervals(intervals2);
        Console.WriteLine("Intervalos unidos:");
        IntervalMerger.PrintIntervals(merged2);

        // --- Ejemplo de anagramas ---
        Console.WriteLine("\nAnagramas:");
        Console.WriteLine(AnagramChecker.AreAnagrams("amor", "roma"));
        Console.WriteLine(AnagramChecker.AreAnagrams("123abc", "c1a2b3"));
        Console.WriteLine(AnagramChecker.AreAnagrams("hola", "holaa"));
        Console.WriteLine(AnagramChecker.AreAnagrams("%^&?", "?&^%"));
    }
}