using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : IComparable<Person>
    {
        public string name;
        public DateTime dob;
        public List<Person> Children = new List<Person>();



        public void WriteToConsole(){
            WriteLine($"{name} was born on a {dob:dddd}");
        }

        public static Person proCreate(Person p1, Person p2){
            var baby = new Person{
                name = $"Baby of {p1.name} and {p2.name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;

        }

        public Person proCreateWith(Person partner){
            return proCreate(this, partner);
        }

        public static Person operator * (Person p1, Person p2){
            return Person.proCreate(p1, p2);
        }

        public static int factorial(int number){
            if(number < 0){
                throw new ArgumentException($"{nameof(number)} cannot be less than 0");
            }
            return localfactorial(number);

            int localfactorial(int localnumber){
                if(localnumber < 1) return 1;
                return localnumber * (localfactorial(localnumber - 1));
            }

        }

        public event EventHandler shout;

        public int angerLevel;

        public void poke(){
            angerLevel++;
            if(angerLevel >= 3){
                if(shout != null){
                    shout(this, EventArgs.Empty);
                }
            }
        }

        public int CompareTo(Person other)
        {
            return name.CompareTo(other.name);
        }

        
    }
}
