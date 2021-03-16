using System;
using static System.Console;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments.");
            
            foreach (string arg in args)
            {
                WriteLine(arg);
            }

            if (args.Length < 3)
            {
                WriteLine("You must specify two color and cursor size, e.g.");
                WriteLine("dontnet run red yellow 50");
                return; // stop running
            }
            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true
            );
            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase: true
            );

            try 
            {
                CursorSize = int.Parse(args[2]);
            }
            catch (PlatformNotSupportedException)
            {
                WriteLine("The currrent platform does not support changing the size of the cursor.");
            }

            /* if (OperatingSystem.IsWindows())
            {
            // execute code that only works on Windows
            } */
            //The OperatingSystem class has equivalent methods for other common OSes 
            // like Android, iOS, Linux, macOS, and even the browser, which is useful for Blazor web components.
        }
    }
}
