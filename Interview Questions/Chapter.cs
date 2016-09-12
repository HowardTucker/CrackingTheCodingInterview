using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Interview_Questions
{
    public class Chapter
    {
        public int ChapterNumber { get; set; }
        public string Title { get; set; }
        public List<IProblem> Problems { get; set; }

        public Chapter(int chapterNumber)
        {
            ChapterNumber = chapterNumber;
            switch (chapterNumber)
            {
                case 1:
                    InitializeChapter1();
                    break;
                default:
                    break;
            }
        }

        public void PrintChapterDescription()
        {
            Console.WriteLine(Title);
            for (int i = 0; i < Problems.Count; i++)
            {
                Console.WriteLine(string.Format("{0}.{1} {2}", ChapterNumber, i + 1, Problems[i].Title));
            }
        }

        private void InitializeChapter1()
        {
            Title = "Arrays and Strings";

            Problems = new List<IProblem>();
            Problems.Add(new CrackingTheCodingInterview.Interview_Questions.Chapter_1.Problem1());
            Problems.Add(new CrackingTheCodingInterview.Interview_Questions.Chapter_1.Problem2());
            Problems.Add(new CrackingTheCodingInterview.Interview_Questions.Chapter_1.Problem3());
        }
    }
}
