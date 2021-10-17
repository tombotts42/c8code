using System;
using SharpPad;
using System.Threading.Tasks;
using static System.Console;

namespace dumping
{
    class Program
    {
        static async Task Main(string[] args)        
        {
            var complexObj = new{
                FirstName = "Tom",
                BirthDay = new DateTime(year: 1969, month:10, day: 30),
                Friends = new[] {"Tom","Matt","Ahmed","Thanh","Hoang","Marcia"}
            };

            WriteLine($"Dumping {nameof(complexObj)} to SharpPad");

            await complexObj.Dump();
            
        }
    }
}
