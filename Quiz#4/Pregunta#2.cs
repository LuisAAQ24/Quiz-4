using System;
using System.Collections.Generic;

public static class AnagramChecker
{
    public static bool AreAnagrams(string s1, string s2)
    {
        // Validaciones iniciales
        if (s1 == null || s2 == null)
            return false;

        // Si las longitudes son diferentes, no pueden ser anagramas
        if (s1.Length != s2.Length)
            return false;

        // Diccionario para contar las ocurrencias de cada carácter
        var counts = new Dictionary<char, int>();

        // Contar caracteres en la primera cadena
        foreach (char c in s1)
        {
            if (counts.ContainsKey(c))
                counts[c]++;
            else
                counts[c] = 1;
        }

        // Verificar caracteres en la segunda cadena
        foreach (char c in s2)
        {
            // Si el carácter no existe en la primera cadena, no es anagrama
            if (!counts.ContainsKey(c))
                return false;

            // Reducimos el contador para este carácter
            counts[c]--;

            // Si el contador es negativo, hay más ocurrencias en s2 que en s1
            if (counts[c] < 0)
                return false;
        }

        // Si pasamos todas las validaciones, son anagramas
        return true;
    }
}
