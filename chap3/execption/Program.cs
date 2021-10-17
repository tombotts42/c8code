using System;
using static System.Console;

namespace execption
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("start");

            Write("Age? ");
            string input = Console.ReadLine();

            try{
                int age = int.Parse(input);
                WriteLine($"You are {age} yrs");
            }
            catch(OverflowException){
                WriteLine($"Aget too big or too small");
            }
            catch(FormatException){
                WriteLine($"Invalid Age");
            }
            catch(Exception ex){
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }

            WriteLine("end");
            
        }
    }
}
