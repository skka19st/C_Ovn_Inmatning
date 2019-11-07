using System;

namespace ovn2
{
    class Program
    {
        static void Main(string[] args)
        {
            // skriver till skärmen
            Console.WriteLine("Vad heter du i efternamn?");

            // läser från skärmen, till variabeln namn
            var enamn = Console.ReadLine();

            // skriver till skärmen
            Console.WriteLine("Vad heter du i förnamn?");

            // läser från skärmen, till variabeln namn
            var fnamn = Console.ReadLine();

            // skriver välkomsthälsning
            // '$' och '{}' är specialtecken för att kunna lägga 
            // in variabler mitt i texten
            Console.WriteLine("Välkommen " + fnamn + " " + enamn + "!");
            Console.WriteLine($"Välkommen {fnamn} {enamn}!");
        }
    }
}
