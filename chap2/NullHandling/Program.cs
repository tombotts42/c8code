using System;

#nullable enable
namespace NullHandling
{

class Address {
    public string? Building;
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;
}

    class Program
    {
        static void Main(string[] args)
        {
            int cannotbenull = 4;
            //cannotbenull = null;

            int? thiscouldbenull = null;

            Console.WriteLine(thiscouldbenull);
            Console.WriteLine(thiscouldbenull.GetValueOrDefault());

            thiscouldbenull = 7;

            Console.WriteLine(thiscouldbenull);
            Console.WriteLine(thiscouldbenull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;

        }
    }
}
