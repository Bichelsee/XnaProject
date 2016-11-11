using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples
{
    class DataTypes
    {
        bool a = true;
        int b = 1;
        string c = "Test";
        double d = 1.34346;
        float e = 12423.123352f;
        

        DataTypes()
        {
            if (a == true) b = 2;

            // Um Float nach Double zu konvertieren
            d = (double)e;

        }

        void Check()
        {
            string blabla = e.ToString();

            if (a == true)
            {
                return;
            }

            while (a == true)
            {
                break;
            }
            
            for (int i = 0; i < 10; i++)
            {
                if (i == 9) break;
            }


            Ball[] peter = new Ball[10];
            foreach (Ball a in peter)
            {
                a.GetA();
            }

        }

    }
}
