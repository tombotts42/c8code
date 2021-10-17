using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person : Object
    {
        public string name;
        public DateTime birthday;
        public Wonders Favwonder;
        public Wonders BucketList;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapien";     
       public readonly string HomePlanet = "Earth";
       public readonly DateTime Instantiated;

       public Person(){
           name = "unknown";
           Instantiated = DateTime.Now;
       }
       public Person(string initname, string homePlanet){
           name = initname;
           HomePlanet = homePlanet;
           Instantiated = DateTime.Now;
       }       

       public void WriteToConsole(){
           WriteLine($"{name} was born on {birthday:dddd}");
       }

       public string getOrigin(){
           return $"{name} was born on {HomePlanet}";
       }

       public (string, int) getFruit(){
           return ("Apples", 5);
       }

        public (string, int, string, int) getxFruit(){
           return ("Apples", 5, "Bananna", 3);
       }

       public (string Name, int Number) getNamedFruit(){
           return(Name: "Apples", Number: 5);
       }

       public string sayHello(){
           return $"{name} says 'Hi!'";
       }

       public string sayHello(string Name){
           return $"{name} says Hi to {Name}";
       }

       public string optParams(
           string command = "Run",
           double number = 0.0,
           bool active = false
       ){
           return string.Format(
               format: "command is {0}, number is {1}, active is {2}",
               arg0: command, arg1: number, arg2: active
           );
       }

       public void passParam(int x, ref int y, out int z){
           z = 99;

           x++;
           y++;
           z++;
       }
    }
    
}
