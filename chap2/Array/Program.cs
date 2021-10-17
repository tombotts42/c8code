using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;

            names = new string[4];

            names[0] = "Tom";
            names[1] = "Melissa";
            names[2] = "Ryan";
            names[3] = "Evan";

            for(int i=0; i < names.Length; i++){
                Console.WriteLine(names[i]);
            }
        }
    }
}
