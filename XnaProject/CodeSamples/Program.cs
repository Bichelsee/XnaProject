using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace definiert den Gültigkeitsbereich.
/// </summary>
namespace CodeSamples
{
    /// <summary>
    /// Private Klasse "Program", wird vom Projekt als Startklasse definiert.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Statische Funktion Main, welche von der ConsoleApplication automatisch aufgerufen wird.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Zerst wird eine Instanz von der Klasse "Test" erstellt. Der Konstuktor wird über den Parametersatz
            // definiert. Hier werden beide Parameter als 1 übergeben.
            Test testInstanz = new Test(1, 1);

            // Die Testinstanz enthält das Objekt "ball1", welches die Funktion "GetA()" hat. Diese gibt einen Integer zurücl.
            int wert = testInstanz.ball1.GetA();
        }
    }
}
