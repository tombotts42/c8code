using System;
using static System.Console;

namespace except
{
    class Program
    {
        static void Main(string[] args)
        {            
            int x,y;
            x = 3;
            y = 2 + ++x;
            WriteLine($"x:{x},y:{y}");

            x = 3 << 2;
            y = 10 >> 1;
            WriteLine($"x:{x},y:{y}");
            
            x = 10 & 8;
            y = 10 | 7;
            WriteLine($"x:{x},y:{y}");

            /*
            Write("num between 0 and 255");
            string a = Console.ReadLine();
            Write("num between 0 and 255");
            string b = Console.ReadLine();
            try{
                int x,y;
                x = int.Parse(a);
                y = int.Parse(b);

                WriteLine($"{a} / {b} = {x/y}");
            }
            catch(FormatException){
                WriteLine("Incorrect format");
            }
            catch(Exception ex){
                WriteLine($"{ex.Message}");
            }
            */
            


        }
    }
}
