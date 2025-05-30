using System;
using System.Collections.Generic;

public static class IntervalMerger
{
    public static List<int[]> MergeIntervals(List<int[]> intervals)
    {
        // Validación de entrada
        if (intervals == null || intervals.Count == 0)
            return new List<int[]>();

        // Ordenar los intervalos por su valor de inicion
        intervals.Sort((a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();
        int[] current = intervals[0]; // Tomamos el primer intervalo como referencia inicial

        // Iterar desde el segundo intervalo
        foreach (var interval in intervals.GetRange(1, intervals.Count - 1))
        {
            // Si el intervalo actual se superpone con el que estamos examinando
            if (interval[0] <= current[1])
            {
                // Combinamos los intervalos, tomando el máximo valor de fin
                current[1] = Math.Max(current[1], interval[1]);
            }
            else
            {
                // No hay superposición, añadimos el actual a los resultados y hacemos del intervalo examinado el nuevo actual
                merged.Add(current);
                current = interval;
            }
        }

        // Añadir el último intervalo procesado
        merged.Add(current);

        return merged;
    }

    public static void PrintIntervals(List<int[]> intervals)
    {
        if (intervals == null)
        {
            Console.WriteLine("null");
            return;
        }

        foreach (var interval in intervals)
        {
            // Validamos que el intervalo tenga exactamente 2 elementos
            if (interval == null || interval.Length != 2)
            {
                Console.Write("invalid ");
                continue;
            }

            Console.Write($"{{{interval[0]},{interval[1]}}} ");
        }
        Console.WriteLine();
    }
}
