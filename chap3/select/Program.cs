using System;
using static System.Console;
using System.IO;


namespace select
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0){
                WriteLine("No args");
            }
            else {
                WriteLine("args exist");
            }

            object o = 3;
            int j = 4;

            if(o is int i){
                WriteLine($"{i} x {j} = {i*j}");
            }
            else {
                WriteLine("o is not an int");
            }

            A_label:

            var number = (new Random()).Next(1,100);
            WriteLine($"random {number}");

            switch(number){
                case 1:
                    WriteLine("1");
                    break;
                case 2:
                    WriteLine("2");
                    break;
                case 3:
                case 4:
                    WriteLine("3 & 4");
                    goto case 1;
                case 5:
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            }

            string path =  @"C:\Users\tbotts01\Documents\APPS\c8code\chap3\select\";

            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            string msg = string.Empty;

            switch(s){
                case FileStream writeableFile when s.CanWrite:
                    msg = "I can write";
                break;
                case FileStream readOnlyFile:
                    msg = "read-only";
                break;
                case MemoryStream ms:
                    msg = "Is mem addy";
                break;
                default:
                    msg = "Other";
                break;
                case null:
                    msg = "null";
                break;
            }

            WriteLine(msg);

            msg = s switch
            {
                FileStream writeableFile when s.CanWrite
                    => "I can write",                
                FileStream readOnlyFile
                    => "read-only",
                MemoryStream ms
                    => "Is mem addy",
                null
                    => "null",
                _
                    => "Other"
            };

            WriteLine(msg);

        }
    }
}
