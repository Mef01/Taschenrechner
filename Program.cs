using System;

namespace Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathVariable mathVariable = new MathVariable();

            Console.WriteLine("Willkommen beim Taschenrechner von Matheesh");

            do
            {
                Console.WriteLine("Geben Sie Ihre Mathematische Gleichung ein (mit Leerzeichen nach jeder Zahl bzw. Operation):");
                mathVariable.function = Console.ReadLine();

                if (!mathVariable.function.Contains(" ")) // Wenn kein leerzeichen verwendet wird kommt die fehlermeldung
                {
                    Console.WriteLine("Fehler: Bitte geben Sie die Gleichung mit Leerzeichen ein.");
                }

            } while (!mathVariable.function.Contains(" ")); // Laest die eingabe solange wiederholen bis es mit leerzeichen geschrieben wurde

            double result = Calculation.Calculate(mathVariable.function);

            Console.Clear(); // Löscht alle Vorherigen console ausgaben 
            Console.WriteLine($"Ihre Gleichung lautet: {mathVariable.function}"); // Ausgabe von der Eingeben Schaltung

            Console.WriteLine($"Das Ergebnis lautet:{result}"); // Ausgabe vom Rechenergebnis
            Console.ReadLine(); // Stopt das Program damit es nicht direkt schließt
        }
    }
}

