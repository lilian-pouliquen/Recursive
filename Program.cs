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
            double fact;
            bool continuer = true;
            int i = 0;

            while(continuer)
            {
                fact = Fonctions.Factorielle(i);
                Console.WriteLine(i + "! = " + fact);
                
                continuer = (i < 171);
               
                i++;
            }



            Console.WriteLine("\n");



            int[] tbl = {0, 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            int[] test = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            foreach(int e in test)
            {
                Console.WriteLine(e + " --> " + Fonctions.Dichotomie(0, tbl.Length - 1, e, tbl));
            }



            Console.WriteLine("\n");



            int a = 37;
            int b = 13;

            Console.WriteLine("PGCD entre " + a + " et " + b + " = " + Fonctions.PGCD(a, b));


            Console.ReadLine();

        }
    } 
}
