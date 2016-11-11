using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSimulator
{
    class Tree
    {
      

        public Branch branch = new Branch();
        public Tree()
        {

        }

        public void LoseApples()
        {
            branch.LoseApples();
        }
    }
}
