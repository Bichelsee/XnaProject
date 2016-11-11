using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSimulator
{
    class Branch
    {
        int apples = 0; 
        public Branch()
        {

        }
        public void AddApple()
        {
            if(apples<5) apples = apples + 1;
        }

        public void AddApples(int count)
        {
            if (apples + count > 4) apples = 5;
            else apples = apples + count;
        }

        public void LoseApples()
        {
            apples = 0;
        }
    }
}
