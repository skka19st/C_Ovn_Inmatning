using System;

namespace ovn1
{
    class Program
    {
        static void Main(string[] args)
        {
            // skriver till skärmen
            Console.WriteLine("Vad heter du?");

            // läser från skärmen, till variabeln namn
            var namn = Console.ReadLine();

            // skriver välkomsthälsning
            Console.WriteLine("Välkommen hit, " +  namn + "!");
        }
    }
}
