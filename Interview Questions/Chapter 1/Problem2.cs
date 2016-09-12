using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Interview_Questions.Chapter_1
{
    /// <summary>
    /// Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.
    /// </summary>
    public class Problem2 : IProblem
    {
        public string Title { get { return "Check Permutation"; } }

        public void Run()
        {
            Console.WriteLine(string.Format("Chapter 1 Problem 2: Check Permutation: Given two strings, write a method to decide if one is a permutation of the other."));
            Console.WriteLine("Enter the first string:");
            var firstString = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            var secondString = Console.ReadLine();

            IsPermutation(firstString, secondString);
        }

        private void IsPermutation(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                //If they aren't the same length then they can't be permutations
                Console.WriteLine(string.Format("{0} and {1} are not permutations of each other.", firstString, secondString));
                return;
            }

            int firstStringComputedValue = 0, secondStringComputedValue = 0;
            for (int i = 0; i < firstString.Length; i++)
            {
                firstStringComputedValue += firstString[i].GetHashCode();
                secondStringComputedValue += secondString[i].GetHashCode();
            }

            if (firstStringComputedValue == secondStringComputedValue)
            {
                Console.WriteLine(string.Format("{0} and {1} are permutations of each other.", firstString, secondString));
            }
            else
            {
                Console.WriteLine(string.Format("{0} and {1} are not permutations of each other.", firstString, secondString));
            }
        }
    }
}
