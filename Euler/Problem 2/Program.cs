///Euler Problem 1 solution by Alden Boby 
///2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

 namespace Euler
  {
   internal class Program
   {
    private static int Palindroming(int a)
    {
        var results = 0;


        while (a > 0)
        {
            results = results * 10 + a % 10;
            a /= 10;
        }


        return results;
    }

    private static void Main(string[] args)
    {
        var multiply = 0;
        var largestMultiply = 0;
        var largest = 0;
        for (var i = 100; i <= 999; i++)
        for (var j = 100; j <= 999; j++)
        {
            var temp = multiply;
            multiply = i * j;

            if (multiply == Palindroming(multiply))
                if (temp > largestMultiply)
                {
                    largestMultiply = temp;

                    if (multiply > largestMultiply)
                        largest = multiply;
                }
        }

        Console.WriteLine(largest);
        Console.ReadLine();
    }
  }
}