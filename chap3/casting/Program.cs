using System;
using static System.Console;
using static System.Convert;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;
            WriteLine(b);   

            double c = 9.8;
            int d = (int)c;
            WriteLine(d);

            long e = 5_000_000_000;
            int f = (int)e;
            WriteLine($"e is {e:N0}, f is {f:N0}");

            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e:N0}, f is {f:N0}");

            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g}, h is {h}");

            double[] doubles = new[]
            {9.49, 9.5, 9.51, 10.49, 10.5, 10.51};

            foreach(double n in doubles){
                WriteLine($"ToInt({n}) is {ToInt32(n)}");
            }

            foreach(double n in doubles){
                WriteLine(format:
                    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                    arg0: n,
                    arg1: Math.Round(value: n,
                        digits: 0,
                        mode: MidpointRounding.AwayFromZero));
            }

            int number = 12;
            WriteLine(number.ToString());

            bool boolean = true;
            WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object me = new object();
            WriteLine(me.ToString());

            byte[] binObj = new byte[128];
            (new Random()).NextBytes(binObj);

            WriteLine("Bin Obj as bytes: ");

            for(int i = 0; i < binObj.Length; i++){
                Write($"{binObj[i]:X} ");                
            }
            WriteLine();

            string encoded = Convert.ToBase64String(binObj);
            WriteLine($"Bin Obj as base64: {encoded}");

            int age = int.Parse("51");
            DateTime bd = DateTime.Parse("30 October 1969");

            WriteLine($"I was born {age} yrs ago");
            WriteLine($"My bd is {bd}");
            WriteLine($"My bd is {bd:D}");

            Write("How many eggs?");
            //int count = int.Parse("abc");
            int count;
            string input = Console.ReadLine();
            if(int.TryParse(input, out count)){
                WriteLine($"There are {input} eggs");
            }
            else {
                WriteLine($"Can't parse");
            }
        }
    }
}
