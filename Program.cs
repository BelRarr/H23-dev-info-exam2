using System;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var liste = new List<int>();
            var moyenne = OperationsMathematiques.CalculerMoyenne(liste);
          
            if (moyenne == -1)
            {
            Console.WriteLine("donnees invalides");
            }
            else
            {
            Console.WriteLine(moyenne);
            }

        }
    }
}