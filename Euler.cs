using System;
using System.Collections;
using System.Collections.Generic;

namespace Euler
{

   //Problem 7
    class Program
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine(""+PrimeNumber());
        }

         static string PrimeNumber()  
        {
            List<int> primes = new List<int>();
            string output = "";
            int num = 2, count = 0;
            
            while(count<10002){
                if(isPrime(num)){
                    primes.Add(num);
                    count++;
                } 
                num++;
            } 
           // Console.WriteLine(count);
          

           //Printing
         
          int length = primes.Count-1;
               output = ""+primes[length];
              

           
           return output;

           
        }


        static bool isPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true; 
        }
    }
}
