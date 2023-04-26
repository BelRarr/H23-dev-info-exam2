using System;
using System.Linq;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public static class OperationsMathematiques
    {
        public static double CalculerMoyenne(List<int> valeurs)
    {
    if (valeurs == null || valeurs.Count == 0)
    {
        // Si la liste est null ou vide, on retourne -1.
        return -1;
    }
    else
    {
        // Sinon, on calcule la moyenne et on la retourne.
        double moyenne = valeurs.Average();
        return moyenne;
    }
     }
    }
}