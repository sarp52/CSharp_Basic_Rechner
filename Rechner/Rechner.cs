using System;


namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variablen deklarieren und dann auf Null initialisieren.
            int num1 = 0; int num2 = 0;


            // Titel als C#-Konsolenrechner-App anzeigen.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");


            // Bitten Sie den Benutzer, die erste Zahl einzugeben.
            Console.WriteLine("Geben Sie eine Zahl ein und drücken Sie dann die Eingabetaste");
            num1 = Convert.ToInt32(Console.ReadLine());


            // Bitten Sie den Benutzer, die zweite Zahl einzugeben.
            Console.WriteLine("Geben Sie eine andere Zahl ein und drücken Sie dann die Eingabetaste");
            num2 = Convert.ToInt32(Console.ReadLine());


            // Bitten Sie den Benutzer, eine Option auszuwählen.
            Console.WriteLine("Wählen Sie eine Option aus der folgenden Liste:");
            Console.WriteLine("\ta - Hinzufügen");
            Console.WriteLine("\ts - Subtrahieren");
            Console.WriteLine("\tm - Multiplizieren");
            Console.WriteLine("\td - Divide");
            Console.Write("Ihre Option? ");

            // Verwenden Sie eine switch-Anweisung, um die Berechnung durchzuführen.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Vor dem Schließen auf die Antwort des Benutzers warten.
            Console.Write("Drücken Sie eine beliebige Taste, um die Rechner-Konsolen-App zu schließen...");
            Console.ReadKey();
        }
    }
}


