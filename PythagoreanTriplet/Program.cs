using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long i = 0; i < 500; i++)
            {
                for (long j = 0; j < 500; j++)
                {
                    for (long k = 0; k < 500; k++)
                    {
                        if((i*i + j*j == k*k) && (i + j + k )== 1000)
                        {
                            long prod = i * j * k;
                            Console.WriteLine("values are {0}, {1}, {2}" , i, j, k);
                            Console.WriteLine(prod);
                        }

                    }
                }
            }
        }
    }
}
