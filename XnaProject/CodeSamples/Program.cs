using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Test testInstanz = new Test(1, 1);
            int wert = testInstanz.ball1.GetA();
        }
    }
}
