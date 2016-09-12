using System;
using System.Collections;

namespace CrackingTheCodingInterview.Interview_Questions.Chapter_1
{
    /// <summary>
    /// Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
    /// </summary>
    public class Problem1 : IProblem
    {
        public string Title { get { return "Is Unique"; } }

        public void Run()
        {
            Console.WriteLine(string.Format("Chapter 1 Problem 1: Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?"));
            Console.WriteLine("Please supply a string for input:");
            var input = Console.ReadLine();
            IsUnique(input);
        }

        private void IsUnique(string input)
        {
            var unique = true;
            var characters = new Hashtable();
            for (int i = 0; i < input.Length; i++)
            {
                if (characters[input[i]] == null)
                {
                    characters.Add(input[i], 1);
                }
                else
                {
                    unique = false;
                    break;
                }
            }

            if (unique)
            {
                Console.WriteLine(string.Format("OUTPUT: {0} does not contain all unique characters.", input));
            }
            else
            {
                Console.WriteLine(string.Format("OUTPUT: {0} contains all unique characters.", input));
            }
        }
    }
}
