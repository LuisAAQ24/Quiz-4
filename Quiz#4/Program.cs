using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== DEMOSTRACIÓN DE UNIÓN DE INTERVALOS ===");
        Console.WriteLine("Caso 1: Intervalos con superposiciones parciales");
        TestIntervalMerge(
            new List<int[]> { new int[] { 1, 6 }, new int[] { 6, 9 }, new int[] { 9, 10 }, new int[] { 2, 4 } },
            "Esperado: {1,10} (todos se superponen)");

        Console.WriteLine("\nCaso 2: Intervalos que contienen a otros completamente");
        TestIntervalMerge(
            new List<int[]> { new int[] { 6, 8 }, new int[] { 1, 9 }, new int[] { 2, 4 } },
            "Esperado: {1,9} (el segundo intervalo cubre a los otros)");

        Console.WriteLine("\nCaso 3: Intervalos sin superposición");
        TestIntervalMerge(
            new List<int[]> { new int[] { 1, 3 }, new int[] { 4, 6 } },
            "Esperado: {1,3} {4,6} (no hay cambios)");

        Console.WriteLine("\n=== DEMOSTRACIÓN DE VERIFICACIÓN DE ANAGRAMAS ===");
        TestAnagram("amor", "roma", true, "Mismas letras, orden diferente");
        TestAnagram("123abc", "c1a2b3", true, "Caracteres alfanuméricos mezclados");
        TestAnagram("hola", "holaa", false, "Diferente longitud");
        TestAnagram("%^&?", "?&^%", true, "Caracteres especiales");
        TestAnagram("Hello", "hello", false, "Case-sensitive: 'H' != 'h'");
    }

    static void TestIntervalMerge(List<int[]> intervals, string description)
    {
        Console.WriteLine($"\nDescripción: {description}");
        Console.Write("Original: ");
        IntervalMerger.PrintIntervals(intervals);

        var merged = IntervalMerger.MergeIntervals(intervals);
        Console.Write("Resultado: ");
        IntervalMerger.PrintIntervals(merged);
    }

    static void TestAnagram(string s1, string s2, bool expected, string description)
    {
        bool result = AnagramChecker.AreAnagrams(s1, s2);
        Console.WriteLine($"\nPrueba: '{s1}' y '{s2}'");
        Console.WriteLine($"Descripción: {description}");
        Console.WriteLine($"Resultado: {result} (Esperado: {expected})");
        Console.WriteLine($"Estado: {(result == expected ? "CORRECTO" : "INCORRECTO")}");
    }
}