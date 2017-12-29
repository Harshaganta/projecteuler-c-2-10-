using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mul = new List<int>();
            string s;
            int len = 0;
            int temp = 0;
            int largestout = 0;
            for (int num1 = 100; num1 < 1000; num1++)
            {
                for (int num2 = 100; num2 < 1000; num2++)
                {
                    mul.Add(num1 * num2);

                }
            }
            foreach (int items in mul)
            {
                s = Convert.ToString(items);
                len = s.Length;

                for (int i = 0; i < len / 2; i++)
                {
                    if (s[i] != s[(len - 1) - i])
                    {
                        break;
                    }
                    if (i == (len / 2) - 1)
                    {
                        temp = Convert.ToInt32(s);
                        if (temp > largestout)
                        {
                            largestout = temp;
                        }
                    }
                }

            }
            Console.WriteLine(largestout);
        }
    }
}
