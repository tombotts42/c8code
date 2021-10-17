using System;
using static System.Console;

namespace iterate
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while(x < 10){
                WriteLine(x);
                x++;
            }

            string pswd = string.Empty;

            x = 0;            
            do {
                Write("pswd");
                pswd = ReadLine();
                x++;
            }
            while (pswd != "haha" && x < 10);
            WriteLine("done");

            for(int i=1; i<=10; i++){
                WriteLine(i);
            }

            string[] names = {"Adam","Barry","Chuck"};

            foreach(string name in names){
                WriteLine($"{name} has {name.Length} char");
            }
        }
    }
}
