///Euler Problem 1 solution by Alden Boby 
///2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static public int Problem_1(int maxval)
        {
            int ans = 0;
            for (int n = 0; n < maxval; n++)
            {
                if (n % 3 == 0 || n % 5 == 0) //finds multiples of five or three
                {
                    ans += n; // adds only the multiples
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int Euler1 = Problem_1(1000);

            Console.WriteLine(Euler1);
            Console.ReadKey();
        }
    }
}
