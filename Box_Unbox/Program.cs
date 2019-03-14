using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object
            var box = new List<object>();

            // Add the following values to the list: 7, 28, -1, true, "chair"
            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add(true);
            box.Add("chair");

            // Loop through the list and print all values (Hint: Type Inference might help here!)
            int sum = 0;
            foreach(var item in box)
            {
                Console.WriteLine(item);
                if(item is int)
                {
                    Console.WriteLine("Looks like we have an int!");
                    sum += (int)item;
                    Console.WriteLine($"Current sum: {sum}");
                }
                // Add all values that are Int type together and output the sum
            }
        }
    }
}