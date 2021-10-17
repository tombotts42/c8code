using System;
using Packt.Shared;
using static System.Console;

namespace peopleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person{name = "harry"};
            var mary = new Person{name = "mary"};
            var jill = new Person{name = "jill"};

            var baby1 = mary.proCreateWith(harry);

            var baby2 = Person.proCreate(harry, jill);

            var baby3 = harry * mary;

            WriteLine($"{harry.name} has {harry.Children.Count} kids");
            WriteLine($"{mary.name} has {mary.Children.Count} kids");
            WriteLine($"{jill.name} has {jill.Children.Count} kids");

            WriteLine(format: "{0}'s first child is name \"{1}\".",
                arg0: harry.name,
                arg1: harry.Children[0].name);  

            WriteLine($"5! is {Person.factorial(5)}");

            harry.shout += harry_shout;
            harry.poke();
            harry.poke();
            harry.poke();
            harry.poke();

            Person[] people = {
                new Person{name="Simon"},
                new Person{name="Jenny"},
                new Person{name="Adam"},
                new Person{name="Richard"}
            };
            WriteLine("init list of folks:");
            foreach(var person in people){
                WriteLine($"{person.name}");
            }
            WriteLine("Use Icomparable");
            Array.Sort(people);
            foreach(var person in people){
                WriteLine($"{person.name}");
            }

            WriteLine("user personcomparer to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people){
                WriteLine($"{person.name}");
            }

            var t1 = new Thing();
            t1.Data = 42;
            WriteLine($"thing with an int: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";
            WriteLine($"thing with a string: {t1.Process("apple")}");

            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            WriteLine($"Gthing with an int: {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            WriteLine($"gthing with a string: {gt2.Process("apple")}");    

            string number1 = "4";
            WriteLine("{0} squared is {1}",
                    arg0: number1,
                    arg1: Squarer.square<string>(number1));

            byte number2 = 3;
            WriteLine("{0} squared is {1}",
                    arg0: number2,
                    arg1: Squarer.square(number2));

            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.x}, {dv1.y}) + ({dv2.x}, {dv2.y}) = ({dv3.x}, {dv3.y}) ");

        }

        private static void harry_shout(object sender, EventArgs e){
            Person p = (Person)sender;
            WriteLine($"{p.name} is this angry: {p.angerLevel}");
        }

        


    }
}
