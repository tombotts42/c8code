using System;
using System.Xml;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Tom";

            Console.WriteLine($"{name} is {height}m");

            //int len1 = name.Length;
            int len2 = ((string)name).Length;

            Console.WriteLine($"{name} has {len2} chars");

            dynamic anothername = "Melissa";
            int len3 = anothername.Length;

            var population = 66_000_000;
            var weight = 1.88;
            var price = 4.99M;
            var fruit = "Apple";
            var letter = 'Z';
            var happy = true;

            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

        }
    }
}
