using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint natNum = 23;
            int intNum = -23;

            float realNum = 2.3F;
            double anRealNum = 2.3;

            int decNot = 2_000_000;
            int binNot = 0b_0001_1110_1000_0100_1000_0000;
            int hexNot = 0x_001E_8480;

            Console.WriteLine($"{decNot == binNot}");
            Console.WriteLine($"{decNot == hexNot}");

            Console.WriteLine($"int uses {sizeof(int)} bytes and has range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and has range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and has range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            Console.WriteLine("using doubles: ");
            double a = 0.1;
            double b = 0.2;

            if(a + b == 0.3){
                Console.WriteLine($"{a} + {b} eq 0.3");
            }
            else {
                Console.WriteLine($"{a} + {b} neq 0.3");
            }

            Console.WriteLine("using decimal: ");
            decimal c = 0.1M;
            decimal d = 0.2M;

            if(c + d == 0.3M){
                Console.WriteLine($"{c} + {d} eq 0.3");
            }
            else {
                Console.WriteLine($"{c} + {d} neq 0.3");
            }
        }
    }
}
