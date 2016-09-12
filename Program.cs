using CrackingTheCodingInterview.Interview_Questions;
using CrackingTheCodingInterview.Interview_Questions.Chapter_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var problems = new ProblemSet();
            problems.SelectProblem();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }

    public class ProblemSet
    {
        public List<Chapter> Chapters { get; set; }

        public ProblemSet()
        {
            InitializeChapters();
        }

        public void SelectProblem()
        {
            Console.WriteLine(@"Enter the chapter and problem number to run in the form chapter.problemNumber i.e. Entering ""1.4"" would run chapter 1 problem 4. Enter ""list"" to a see a list of available problems.");
            var input = Console.ReadLine();
            if (input == "list")
            {
                foreach (var chapter in Chapters)
                {
                    chapter.PrintChapterDescription();
                }
            }
        }

        private void InitializeChapters()
        {
            Chapters = new List<Chapter>();
            Chapters.Add(new Chapter(1));
        }

    }
}
