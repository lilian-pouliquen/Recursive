using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fonctions.Factorielle(3));

            int[] tbl = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int pos = Fonctions.Dichotomie(10, tbl);

            if ( pos == -1)
            {
                Console.WriteLine("Pas trouvé");
            }
            else
            {
                Console.WriteLine(pos);
            }


            Console.ReadLine();

        }
    }
}
