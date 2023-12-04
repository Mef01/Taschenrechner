using System;
using System.Globalization;

namespace Taschenrechner
{
    internal class Calculation
    {
        public static double Calculate(string function)
        {
            CultureInfo culture = CultureInfo.InvariantCulture; // ist dafür das der punkt als dezimalzahl anerkannt wird.

            function = function.Replace(',','.'); // aendert Kommas in Punkt damit man dezimalzahlen verweden kann.

            string[] elements = function.Split(' '); // Teilt die Nummern , Klammern und Operationen in ein array auf

            double result = double.Parse(elements[0], culture);


            for (int i = 1; i < elements.Length; i += 2)
            {
                string op = elements[i];
                double nextNumber = double.Parse(elements[i + 1]);

                switch (op)
                {
                    case "+":
                        result += nextNumber;
                        break;
                    case "-":
                        result -= nextNumber;
                        break;
                    case "*":
                        result *= nextNumber;
                        break;
                    case "/":
                        result /= nextNumber;
                        break;
                }
            }
                return result;
        }
    }
hallo123
