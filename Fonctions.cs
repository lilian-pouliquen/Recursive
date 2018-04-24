using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursives
{
    public class Fonctions
    {
        public static int Factorielle(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorielle(n - 1);
            }
        }

        public static int Dichotomie(int recherche, int[] tbl)
        {
            int inf = 0;
            int sup = tbl.Length - 1;
            int m = (int)((inf + sup) / 2);

            while (m != -1 && tbl[m] != recherche )
            {
                if (tbl[m] < recherche) { inf = m; }
                else { sup = m; }
                
                if((int)((inf + sup) / 2) == m) { m = -1; }
                else { m = (int)((inf + sup) / 2); }
            }
            
            return m;
        }


    }





    


}
