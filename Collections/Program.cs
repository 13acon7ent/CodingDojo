using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            int[] exArr = {0,1,2,3,4,5,6,7,8,9};
            for(int idx = 0; idx < exArr.Length; idx++)
            {
                //Console.WriteLine($"The {exArr[idx]} number of the arr is {exArr[idx]}");
            }
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] exArr2 = {"Tim", "Martin", "Nikki", "Sara"};
            for (int idx1 = 0; idx1 < exArr2.Length; idx1++)
            {
                //Console.WriteLine($"The name of the arr is {exArr2[idx1]}");
            }
            // Create an array of length 10 that alternates between true and false values, starting with true
            string[] exArr3 = new string []{"True","False","True","False","True","False","True","False","True","False"};
            for (int idx2 = 0; idx2 < exArr3.Length; idx2++)
            {
                //Console.WriteLine($"The response is {exArr3[idx2]}");
            }

            // List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> IceKream = new List<string>();
            IceKream.Add("Vanilla");
            IceKream.Add("Mint");
            IceKream.Add("Coffee");
            IceKream.Add("Chocolate");
            IceKream.Add("Orange Cream");
            IceKream.Add("Rocky Road");

            // Output the length of this list after building it
            // Console.WriteLine(IceKream.Count);
            // Output the third flavor in the list, then remove this value
            // Console.WriteLine(IceKream[2]);
            IceKream.Remove(IceKream[2]);
            // Output the new length of the list (It should just be one fewer!)
            //Console.WriteLine(IceKream.Count);

            // User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> test_dict = new Dictionary<string,string>();
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            foreach(var name in exArr2)
                test_dict.Add(name, null);
            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random rand = new Random();
            foreach(var name in exArr2)
                test_dict[name] = (IceKream[rand.Next(IceKream.Count)]);
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach(var kp in test_dict)
                Console.WriteLine($"{kp.Key} prefers {kp.Value}");
        }
    }
}
