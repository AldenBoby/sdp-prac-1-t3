﻿///Euler Problem 1 solution by Alden Boby 
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
            int ans = 3;
            for (int n = 0; n < maxval; n++)
            {
                if (n % 3 == 0 || n % 5 == 0) //finds multiples of five or three
                {
                    ans += n; // adds only the multiples
                }
            }
            return ans;
        }
        static string PrimeNumber()
        {
            List<int> primes = new List<int>();
            string output = "";
            int num = 2, count = 0;

            while (count < 10002)
            {
                if (isPrime(num))
                {
                    primes.Add(num);
                    count++;
                }
                num++;
            }
            // Console.WriteLine(count);
            //Printing
            int length = primes.Count - 1;
            output = "" + primes[length];
            return output;
        }

        static string evenFibonacciSum(int maxValue=4000000)
        {
            if(maxValue>4000000) return "Cannot exceed a max value of 4 000 000"
            int sum = 0;
            for (int i = 1; i <=maxValue; i++)
            {
                sum = i % 2 == 0 ? sum + i : sum;
            }
            return "Sum of even valued terms in fibbonaci sequence "+sum;
        }

        static bool isPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int Euler1 = Problem_1(1000);

            Console.WriteLine("Problem 1: "+Euler1);
            Console.WriteLine("Problem 7: " + PrimeNumber());
            Console.WriteLine("Problem 2: " + evenFibonacciSum());
            Console.ReadKey();
        }
    }
}
