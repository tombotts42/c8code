using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class ThingofDefaults
    {
        public int population;
        public DateTime When;
        public string Name;
        public List<Person> People;

        public ThingofDefaults()
        {
            population = default;
            When = default;
            Name = default;
            People = default;
        }
    }
}