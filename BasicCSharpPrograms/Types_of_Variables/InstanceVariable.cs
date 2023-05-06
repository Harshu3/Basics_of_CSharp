using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPrograms.Types_of_Variables
{
    internal class Marks
    {
        public int physics;
        public int maths;

        public void GetMarks()
        {
            Console.WriteLine("Physics:{0} Maths:{1}", physics, maths);
        }
    }
}
