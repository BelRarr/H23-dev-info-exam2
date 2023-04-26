using System;
using System.Linq;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public static class OperationsMathematiques
    {
        public static double CalculerMoyenne(List<int> valeurs)
        {
            double moyenne ;
            if(valeurs.count==0){
                moyenne =-1
            }else{
                moyenne = valeurs.Average()
            }
            Console.WriteLine($" La moyenne est : {moyenne}")
            return moyenne;                                          
        }
    }
}