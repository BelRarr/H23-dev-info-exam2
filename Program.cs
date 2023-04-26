using System;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public class Program
    {
        public static void Main(string[] args)
{
    // Créer une nouvelle liste d'entiers vide.
    var liste = new List<int>();

    // Appeler la méthode statique CalculerMoyenne de la classe OperationsMathematiques
    // en lui passant la liste vide créée précédemment comme argument.
    var moyenne = OperationsMathematiques.CalculerMoyenne(liste);

    // Vérifier si la moyenne est égale à -1.
    if (moyenne == -1)
    {
        // Afficher un message d'erreur si la moyenne est égale à -1.
        Console.WriteLine("Données invalides");
    }
    else
    {
        // Sinon, afficher la moyenne calculée à l'écran.
        Console.WriteLine(moyenne);
    }
}

    }
}