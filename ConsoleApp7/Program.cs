using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            

            for (int i=0; i<=a; i++)
            {
                if (i % 3==0 || i % 5 == 0)
                {
                    
                    Console.WriteLine(i);
                }
            }
            
           
            
        }
    }
}
