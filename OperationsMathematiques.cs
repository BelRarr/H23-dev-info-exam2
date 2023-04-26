using System;
using System.Linq;
using System.Collections.Generic;


namespace H23_Dev_Info_Examen2
{
    public static class OperationsMathematiques
    {
        public static double CalculerMoyenne(List<int> valeurs)
        {
            if(valeurs == null){
                return -1;
            }else{
                double moyenne = valeurs.Average();
                return moyenne;
            }
                                                    
        }
    }
}