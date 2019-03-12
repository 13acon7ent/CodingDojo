using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");
            // Create a Loop that prints all values from 1-255
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both  
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }         
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5  
            for(int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz"); // for multiples of both 3 and 5  
                }
                else
                {
                    Console.WriteLine(i);
                }  
            }       
            //(Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
            int ii = 1;
            while(ii <= 255)
            {
                Console.WriteLine(ii);
                ii = ii + 1;
            }
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both 
            
            while(ii <= 100)
            {
                if(ii % 3 == 0)
                {
                    Console.WriteLine(ii);
                    ii = ii + 1;
                }
                else if (ii % 5 == 0)
                {
                    Console.WriteLine(ii);
                    ii = ii + 1;
                }
            }
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5  
            while(ii <= 100)
            {
                if (ii % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (ii % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (ii % 5 == 0)
                {
                    Console.WriteLine("Buzz"); // for multiples of both 3 and 5  
                }
                else
                {
                    Console.WriteLine(ii);
                }  
            }   
        }  
    }
}