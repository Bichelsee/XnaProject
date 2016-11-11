using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            for (int i = 1; i < 3; i++)
            {  
                tree.branch.AddApple();
            }
            tree.branch.AddApples(4);
            tree.LoseApples();
        }
    }
}
