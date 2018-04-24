using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursives
{
    public class Fonctions
    {
        public static double Factorielle(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorielle(n - 1);
            }
        }

        public static int Dichotomie(int inf, int sup, int recherche, int[] tbl)
        {
            int m = (inf + sup) / 2;

            if (tbl[m] == recherche)
            {
                return m;
            }
            else
            {
                if (tbl[m] < recherche) { inf = m + 1; }
                else
                {
                    if (tbl[m] > recherche) { sup = m - 1; }
                }

                if (sup < inf)
                {
                    return -1;
                }
                else
                {
                    return Dichotomie(inf, sup, recherche, tbl);
                }
            }
        }

        public static int PGCD(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else
            {
                if(a > b)
                {
                    return PGCD(a - b, b);
                }
                else
                {
                    return PGCD(a, b-a);
                }
            }
        }

    }








}
