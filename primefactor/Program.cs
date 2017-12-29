using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primefactor
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isprime = true;
            long a = Convert.ToInt32(Console.ReadLine());
            long num = 0;
            for(long i= 2; i < a; i++)
            {
                for (long n = 2; n < i; n++)
                {
                    if (i % n == 0 && i != n)
                    {
                        isprime = false;
                        break;

                    }
                    

                }
                if(isprime)
                {
                    num += i;
                    
                }
                isprime = true;
            }
            Console.WriteLine(num);
        }
    }
}
