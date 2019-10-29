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
            //THE COMMENTED CODE BELOW COMPLETES THE TASK BUT USES ONLY THE IF STATEMENT...(FOR THE NAIVE PROGRAMMER)
            /*int i=0; //declare and initialize a variable to store the number
            //a loop to iterate from 1 to 100
            for (i=1;i<=100;i++)
            {
                if(i % 3!=0 && i%5!=0) //if the number is not a multiple of either 3 or 5
                {
                    WriteLine(i);
                }
                if(i%3==0 && i%5!=0) //if the number is a multiple of 3 and not 5
                {
                    WriteLine("Fizz");
                }
                if(i%5==0 && i % 3!= 0) //if the number is a multiple of 5 and not 3
                {
                    WriteLine("Buzz");
                }
                if(i%5==0 && i%3==0) //if the number is a multiple of both
                {
                    WriteLine("FizzBuzz");
                }
            }
            ReadKey();*/

            //RECOMMENDED WAY TO DO IT
            //INFORM THE USER OF WHAT THE PROGRAM ENTAILS AND GIVES HIM/HER AN OPTION TO CHOOSE A RANGE
            WriteLine("Multiples of 3 = Fizz");
            WriteLine("Multiples of 5 = Buzz");
            WriteLine("Multiples of both 3 and 5 = FizzBuzz");
            WriteLine("Enter the wanted limit of fizz, buzz and fizzbuzz");
            limit = int.Parse(ReadLine()); //Convert input to int datatype
            fibuzz(); //call the method to be executed
        }

        private static void fibuzz() //method to carry out the task
        {
            int h;
            for (h = 1; h <= limit; h++)
            {
                if (h % 3 == 0 && h % 5 != 0)
                    WriteLine("..Fizz");
                if (h % 5 == 0 && h % 3 != 0)
                    WriteLine("..Buzz");
                if (h % 3 != 0 && h % 5 != 0)
                    WriteLine(h);
                if (h % 3 == 0 && h % 5 == 0)
                    WriteLine("..FizzBuzz \n");
                
            }
            ReadKey();
        }

       
    }
}
