using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static int limit = 0;
       public static void Main()
        {
            /*  int i=0; //declare and initialize a variable
              for (i=1;i<=100;i++)
              {
                  if(i%3!=0 && i%5!=0)
                  {
                      WriteLine(i);
                  }
                  if(i%3==0)
                  {
                      WriteLine("Fizz");
                  }
                  if(i%5==0)
                  {
                      WriteLine("Buzz");
                  }
                  if(i%5==0 && i%3==0)
                  {
                      WriteLine("FizzBuzz");
                  }
              }
              ReadKey();*/
            WriteLine("Multiples of 3= Fizz");
            WriteLine("Multiples of 5= Buzz");
            WriteLine("Multiples of both 3 and 5= FizzBuzz");
            WriteLine("Enter the wanted limit of fizz, buzz and fizzbuzz");
            limit = int.Parse(ReadLine());
        }

        private static void fibuzz()
        {
            int h;
            for (h = 1; h <= limit; h++)
            {
                if (h % 3 == 0)
                    WriteLine("..Fizz");
                if (h % 5 == 0)
                    WriteLine("..Buzz");
                if (h % 3 != 0 && h % 5 != 0)
                    WriteLine(h);
                if (h % 3 == 0 && h % 5 == 0)
                    WriteLine("..FizzBuzz \n");
                ReadKey();
            }
        }

        private class lim
        {
        }
    }
}
