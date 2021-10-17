using System;
using static System.Console;
using Packt.Shared;
using SharpPad;
using System.Threading.Tasks;


namespace peopleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var bob = new Person();
            WriteLine(bob.ToString());

            bob = new Person();
            bob.name = "Tom Botts";
            bob.birthday = new DateTime(1969, 10, 30);
            WriteLine("{0} was born {1:dddd, d MMMM yyyy}",
            arg0: bob.name,
            arg1: bob.birthday);

            var Melissa = new Person{
                name = "Melissa Newton Botts",
                birthday = new DateTime(1973, 5, 1)
            };
            WriteLine("{0} was born {1:dddd, d MMMM yyyy}",
            arg0: Melissa.name,
            arg1: Melissa.birthday);

            bob.Favwonder = Wonders.Pyramids;
            WriteLine(format: "{0}'s fav wonder is {1}, it's integer is {2}.",
            arg0: bob.name,
            arg1: bob.Favwonder,
            arg2: (int)bob.Favwonder);

            bob.BucketList = Wonders.HangingGardens | Wonders.Mausoleum;
            //bob.BucketList = (Wonders)18;

            WriteLine($"{bob.name}'s bucket list is {bob.BucketList}");

            bob.Children.Add(new Person{name="Ryan"});
            bob.Children.Add(new Person{name="Evan"});

            WriteLine($"{bob.name} has {bob.Children.Count} childrens");
            for (int i=0; i < bob.Children.Count; i++){
                WriteLine($"  {bob.Children[i].name}");
            }            

            BankAccount.InterestRate = 0.012M;

            var jonesAcct = new BankAccount();
            jonesAcct.AcctName = "Mrs. Jones";
            jonesAcct.Balance = 2400;

            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: jonesAcct.AcctName,
                arg1: jonesAcct.Balance * BankAccount.InterestRate
            );

            var gerAcct = new BankAccount();
            gerAcct.AcctName = "Ms. Ger";
            gerAcct.Balance = 98;

            WriteLine(format: "{0} earned {1:C} interest.",
            arg0: gerAcct.AcctName,
            arg1: gerAcct.Balance = gerAcct.Balance * BankAccount.InterestRate);

            WriteLine($"{bob.name} is a {Person.Species}");

            WriteLine($"{bob.name} was born on {bob.HomePlanet}");

            var blankperson = new Person();
            WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
                arg0: blankperson.name,
                arg1: blankperson.HomePlanet,
                arg2: blankperson.Instantiated);

            var gunny = new Person("Gunny", "Mars");
            WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
                arg0: gunny.name,
                arg1: gunny.HomePlanet,
                arg2: gunny.Instantiated);     

            //var test = new ThingofDefaults();
            //await test.Dump();

            bob.WriteToConsole();
            WriteLine(bob.getOrigin());

            (string, int) fruit = bob.getFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            (string, int, string, int) fruitx = bob.getxFruit();
            WriteLine($"{fruitx.Item1}, {fruitx.Item2} there are. {fruitx.Item3}, {fruitx.Item4} there are.");

            var FruitNamed = bob.getNamedFruit();
            WriteLine($"{FruitNamed.Name}, {FruitNamed.Number} there is");
            
            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} things");

            var thing2 = (bob.name, bob.Children.Count);
            WriteLine($"{thing2.name} has {thing2.Count} thingys");

            (string fruitName, int fruitNumber) = bob.getFruit();
            WriteLine($"deconstructed: {fruitName}, {fruitNumber}");

            WriteLine(bob.sayHello());
            WriteLine(bob.sayHello("Melissa"));

            WriteLine(bob.optParams());

            WriteLine(bob.optParams("Jump", 98.5));

            WriteLine(bob.optParams(number: 52.7, command: "Hide"));

            WriteLine(bob.optParams("Poke", active: false));

            int a = 10;
            int b = 20;
            int c = 30;

            WriteLine($"before a = {a}, v = {b}, c = {c}");
            bob.passParam(a, ref b, out c);
            WriteLine($"After a = {a}, b = {b}, c = {c}");

            int d = 10;
            int e = 20;

            WriteLine($"before d = {d}, e = {e}");
            bob.passParam(d, ref e, out int f);
            WriteLine($"After d = {d}, e = {e}, f = {f}");

            var sam = new Person
            {
                name = "Mel",
                birthday = new DateTime(1973, 5, 1)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.age);

            sam.FavIceCream = "choc chip";
            WriteLine($"{sam.name} fav ice cream is {sam.FavIceCream}");

            sam.FavPrimaryColor = "Blue";
            WriteLine($"{sam.name} fav colour is {sam.FavPrimaryColor}");

            sam.Children.Add(new Person{name="chuck"});
            sam.Children.Add(new Person{name="Eller"});

            WriteLine($"Sam's first child is {sam.Children[0].name}");
            WriteLine($"Sam's second child is {sam.Children[1].name}");
            WriteLine($"Sam's first child is {sam[0].name}");
            WriteLine($"Sam's second child is {sam[1].name}");


        }
    }
}
