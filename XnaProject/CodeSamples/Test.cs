using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples
{
    public class Test
    {
        public int x;
        public int y = 0;
        public Ball ball1;
        public Ball ball2;
        public Ball ball3;
        public Ball ball4;
        public Ball ball5;

        public Test()
        {

        }

        public Test(int paramX, int paramY)
        {
            x = paramX;
            y = paramY;


            ball1 = new Ball();
            ball2 = new Ball();
            ball3 = new Ball();
            ball4 = new Ball();
            ball5 = new Ball();
        }

        public void A(int paramY)
        {
            y = paramY;
        }
    }
}
