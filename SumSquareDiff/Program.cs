using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 100;
            long n1 = 0;
            long nsqr = 0;

            n1 = n * (n + 1)/2;
            nsqr = (n * (n + 1) * (2 * n + 1)) / 6;
            
            Console.WriteLine( (n1 * n1) - nsqr);
        }
    }
}
