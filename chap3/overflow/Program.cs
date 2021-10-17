using System;
using static System.Console;

namespace overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            checked{
                int x = int.MaxValue - 1;

                WriteLine($"Start {x}");
                x++;
                WriteLine($"After increment {x}");
                x++;
                WriteLine($"After increment {x}");
                x++;
                WriteLine($"After increment {x}");                
            }
            }
            catch(OverflowException){
                WriteLine("Overflow");
            }

            unchecked{
                int y = int.MaxValue + 1;
                WriteLine($"Start {y}");
                y--;
                WriteLine($"After decrement {y}");
                y--;
                WriteLine($"After decrement {y}");
                y--;
                WriteLine($"After decrement {y}");                
            }

            int max = 500;
            checked{
            for(byte i = 0; i < max; i++){
                WriteLine(i);
            }
            }
        }
    }
}
