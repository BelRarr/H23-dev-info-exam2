using System;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public static void Main(string[] args)
    {
        var liste = new List<int>();
        var moyenne = OperationsMathematiques.CalculerMoyenne(liste);

        // V�rifier si la moyenne est �gale � -1
        if (moyenne == -1)
        {
            Console.WriteLine("donn�es invalides");
        }
        else
        {
            Console.WriteLine(moyenne);
        }
    }
}