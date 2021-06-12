using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    class Program
    {
        static void Main(string[] args)
        {
            CDiophantine dp = new CDiophantine(1, 2, 3, 4, 30);
            int ans;
            ans = dp.Solve();
            Gene gn = new Gene();
            
            if (ans == -1)
            {
                Console.WriteLine("Решения не найдены");
            }
            else
            {
                gn = dp.GetGene(ans);

                Console.WriteLine("The solution set to a+2b+3c+4d=30 is");
                Console.WriteLine("a = " + gn.alleles[0]);
                Console.WriteLine("b = " + gn.alleles[1]);
                Console.WriteLine("c = " + gn.alleles[2]);
                Console.WriteLine("d = " + gn.alleles[3]);
            }

            Console.ReadLine();
        }
    }
}
