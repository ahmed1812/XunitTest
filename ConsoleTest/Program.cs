using System;
using System.Collections.Generic;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of numbers
            int[] numbers = { 5, 5, 6,6, 7, 8, 8, 9, 9, 9 };

            // Create a dictionary to store the number of occurrences of each number
            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            // Loop through the array and add the number of occurrences of each number to the dictionary
            foreach (int num in numbers)
            {
                if (!occurrences.ContainsKey(num))
                {
                    occurrences.Add(num, 1);
                }
                else
                {
                    occurrences[num]++;
                }
            }

            // Loop through the dictionary and print the unique numbers
            foreach (KeyValuePair<int, int> kvp in occurrences)
            {
                if (kvp.Value == 1)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        
    }
    }
}
