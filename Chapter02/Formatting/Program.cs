using System;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;
            WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
            );
            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
            );
            // WriteToFile(formatted); // writes the string into file
                                       // nonexistant method used to illustrate the data

            WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            // The full syntax of a format item is:
            // { index [, alignment ] [ : formatString ] }
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;
            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count"
            );
            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount
            );
            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );

            // Getting text input from the user
            WriteLine("Type your first name and press ENTER: ");
            string firstName = Console.ReadLine();
            Write("Type your age and press Enter: ");
            string age = Console.ReadLine();
            WriteLine($"Hello {firstName}, you look good for {age}.");

            //Getting key input from the user
            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine(
                "Key: {0}, char: {1}, Modifiers: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers
            );
        }
    }
}
