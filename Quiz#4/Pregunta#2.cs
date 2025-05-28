using System;
using System.Collections.Generic;

public class AnagramChecker
{
    public static bool AreAnagrams(string s1, string s2)
    {
        if (s1 == null || s2 == null)
            return false; //Verificar que no sean nulos

        if (s1.Length != s2.Length)
            return false; //No tienen misma longitud

        var counts = new Dictionary<char, int>();

        // Contar caracteres de s1
        foreach (char c in s1)
        {
            if (counts.ContainsKey(c))
                counts[c]++;
            else
                counts[c] = 1;
        }

        // Restar caracteres de s2
        foreach (char c in s2)
        {
            if (!counts.ContainsKey(c))
                return false; //validación que contenga el caracter

            counts[c]--;

            if (counts[c] < 0)
                return false; //Si llega aquí significa que hay más caracteres del mismo tipo en s2
        }

        // Ambos misma cantidad de apariciones de las mismas letras
        return true;
    }
}
