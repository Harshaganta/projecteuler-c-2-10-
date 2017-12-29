using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isprime = true;
            long num = 2;
            int count = 0;
            for (int i = 2; i >= num; i++)
            {
                for (int n = 2; n <= i; n++)
                {
                    if (i % n == 0 && i != n)
                    {
                        isprime = false;
                        num++;
                        break;


                    }


                }
                if (isprime)
                {
                    count++;
                    num++;

                }
                isprime = true;
                if (count == 10001)
                {
                    Console.WriteLine(i);
                    break;
                }

            }
        }  
    }
}
