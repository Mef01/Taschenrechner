using System;
using System.Globalization;

namespace Taschenrechner
{
    internal class Calculation
    {
        public static double Calculate(string function)
        {
            CultureInfo culture = CultureInfo.InvariantCulture; // ist dafür da dass der Punkt als Dezimalzahl anerkannt wird.

            function = function.Replace(',', '.'); // ändert Kommas in Punkte damit Dezimalzahlen verwendet werden können.

            // Teilt die Zahlen, Klammern und Operationen in ein Array auf
            string[] elements = function.Split(' ');

            // Punkt vor Strich Rechnung
            for (int i = 1; i < elements.Length; i += 2)
            {
                string op = elements[i];

                if (op == "*" || op == "/")
                {
                    double leftOperand = double.Parse(elements[i - 1], culture);
                    double rightOperand = double.Parse(elements[i + 1], culture);

                    // Führe die entsprechende Operation durch
                    double result = (op == "*") ? leftOperand * rightOperand : leftOperand / rightOperand;

                    // Aktualisiere der Zahl im Array 
                    elements[i - 1] = result.ToString(culture);
                }
            }

            // Hier wird nach der Punkt vor Strich rechnung der rest ausgerechnet
            double finalResult = double.Parse(elements[0], culture);

            for (int i = 1; i < elements.Length; i += 2)
            {
                string op = elements[i];
                double nextNumber = double.Parse(elements[i + 1], culture);

                switch (op)
                {
                    case "+":
                        finalResult += nextNumber;
                        break;
                    case "-":
                        finalResult -= nextNumber;
                        break;
                }
            }
            return finalResult;
        }
    }
}

