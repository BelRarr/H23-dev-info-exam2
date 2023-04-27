using System;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public static void Main(string[] args)
    {
        var liste = new List<int>();
        var moyenne = OperationsMathematiques.CalculerMoyenne(liste);

        // Vérifier si la moyenne est égale à -1
        if (moyenne == -1)
        {
            Console.WriteLine("données invalides");
        }
        else
        {
            Console.WriteLine(moyenne);
        }
    }
}