using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples
{
    // Statische Klasse Calc, welche nicht instanziert werden kann, deshalb auch keinen Konstruktor hat.
    public static class Calc
    {
        // Statische Variable a, nur einmal existent
        public static int a;

        // Statische Funktion, welche einen Integer zurück gibt.
        public static int DoSomething()
        {
            return 1;
        }
    }
}
