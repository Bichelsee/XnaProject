using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples
{
    public class Test
    {
        // Variabeln
        public int x;
        public int y = 0;
        public Ball ball1;
        public Ball ball2;
        public Ball ball3;
        public Ball ball4;
        public Ball ball5;

        /// <summary>
        ///  Konstuktor welcher ohne Parameter aufgerufen werden kann.
        /// </summary>
        public Test()
        {
              
        }

        /// <summary>
        /// Konstruktor der zwei Integer benötigt.
        /// </summary>
        /// <param name="paramX">Mike</param>
        /// <param name="paramY">Hans</param>
        public Test(int paramX, int paramY)
        {
            // Parameter werden den Variabeln zugewiesen
            x = paramX;
            y = paramY;


            // Statische Funktion wird aufgerufen, ohne dass vorher instanziert wird
            Calc.DoSomething();

            // Ball wird instanziert
            ball1 = new Ball();
            ball2 = new Ball();
            ball3 = new Ball();
            ball4 = new Ball();
            ball5 = new Ball();
        }

        /// <summary>
        /// Funktion, welche nichts zurück gibt (void) und aber einen Parameter verwendet. 
        /// </summary>
        /// <param name="paramY"></param>
        public void A(int paramY)
        {
            y = paramY;
        }
    }
}
