using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Interview_Questions.Chapter_1
{
    /// <summary>
    /// URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient
    /// space at the end to hold the additional characters, and that you are given the "true" length of the string.
    /// (Note: If implementing in Java, please use a character array so that you can perform this operation in place.)
    /// </summary>
    class Problem3 : IProblem
    {
        public string Title { get { return "URLify"; } }

        public void Run()
        {
            Console.WriteLine(string.Format(@"Chapter 1 Problem 3: URLify: Write a method to replace all spaces in a string with '%20'. " +
                @"You may assume that the string has sufficient space at the end to hold the additional characters, and that you are giv en " +
                @"the ""true"" length of the string. (Note: If implementing in Java, please use a character array so that you can perform " +
                @"this operation in place.)"));
            Console.WriteLine("Enter a string:");

            Urlify(Console.ReadLine());
        }

        private void Urlify(string input)
        {
            char[] charArray = input.ToArray<char>();
            int spacesCount = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    spacesCount++;
                }
            }

            char[] outputArray = new char[input.Length + spacesCount * 2];
            int outputIndex = input.Length + spacesCount * 2 - 1;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                if (charArray[i] == ' ')
                {
                    outputArray[outputIndex] = '0';
                    outputArray[outputIndex - 1] = '2';
                    outputArray[outputIndex - 2] = '%';
                    outputIndex -= 3;
                }
                else
                {
                    outputArray[outputIndex] = charArray[i];
                    outputIndex--;
                }
            }

            Console.WriteLine(string.Format("URLified string: {0}", new String(outputArray)));
        }
    }
}
