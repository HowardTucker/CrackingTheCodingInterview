using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Interview_Questions
{
    public interface IProblem
    {
        String Title { get; }
        void Run();
    }
}
