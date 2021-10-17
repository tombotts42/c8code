using System;
using static System.Console;

namespace formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numApples = 12;
            decimal priceApple = 0.35M;

            WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numApples,
                arg1: priceApple * numApples
            );

            //WriteToFile(formatted);

            WriteLine($"{numApples} apples cost {priceApple * numApples:C}");

            string applestxt = "Apples";
            int applesCount = 1234;
            string bantxt = "Bananas";
            int banCount = 56789;

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count"
            );

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applestxt,
                arg1: applesCount
            );

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bantxt,
                arg1: banCount
            );

            Write("FName");
            string fname = ReadLine();

            Write("Age");
            string age = ReadLine();

            WriteLine($"Hello {fname}, u are {age}");

            Write("Press key");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine("Key {0}, char {1}, mods {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers
            );


        }

    }
}
