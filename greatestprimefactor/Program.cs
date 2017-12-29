using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greatestprimefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            primefactor(100);
        }
         public static void primefactor(long a)
        {
            long remainingfactor = 1;
            List<long> b = new List<long>();
            for (long i = 2;i< a; i++)
            {
                if (a % i == 0)
                {
                    b.Add(i);
                    remainingfactor = a / i;
                    a = remainingfactor;
                    i = 1;
                   

                }
            }
            Console.WriteLine("largest prime factor: " + b.Max());

            

         }
    }
}
