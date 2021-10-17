using System;
using static System.Console;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = string.Empty;
            for(int i = 1; i <= 100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                    msg = "fizzbuzz";
                }
                else if(i % 3 == 0){
                    msg = "fizz";
                }
                else if(i % 5 == 0){
                    msg = "buzz";
                }
                else {
                    msg = "";
                }
                WriteLine($"{i} says {msg}");                
            }
        }
    }
}
