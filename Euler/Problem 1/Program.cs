///Euler Problem 1 solution by Alden Boby 
///2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            for (int n = 0; n < 1000; n++)
            {
                if (n % 3 == 0 || n % 5 == 0) //finds multiples of five or three
                {
                    ans += n; // adds only the multiples
                }
            }
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
