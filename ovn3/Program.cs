using System;

namespace ovn3
{
    class Program
    {
        static void Main(string[] args)
        {
            // skriver till skärmen
            Console.WriteLine("Person1: Vad heter du i efternamn?");

            // läser från skärmen, till variabeln enamn1
            var enamn1 = Console.ReadLine();

            // skriver till skärmen
            Console.WriteLine("Person1: Vad heter du i förnamn?");

            // läser från skärmen, till variabeln fnamn1
            var fnamn1 = Console.ReadLine();

            // samma sak för person 2
            Console.WriteLine("Person2: Vad heter du i efternamn?");
            var enamn2 = Console.ReadLine();
            Console.WriteLine("Person2: Vad heter du i förnamn?");
            var fnamn2 = Console.ReadLine();

            // skriver välkomsthälsning
            // '$' och '{}' är specialtecken för att kunna lägga 
            // in variabler mitt i texten
            Console.Write($"{fnamn1} {enamn1} och {fnamn2} {enamn2} ");
            Console.Write("skulle spela badminton. ");
            Console.WriteLine($"{fnamn1} snubblade på {fnamn2}s skosnören. ");
            Console.Write($"Lag {enamn1}/{enamn2} utgår pga skada, ");
            Console.WriteLine("rapporterade speakern. ");
        }
    }
}
