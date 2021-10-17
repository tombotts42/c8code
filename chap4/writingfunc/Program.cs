using System;
using static System.Console;

namespace writingfunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunTimesTable();
            //RunCalcTax();
            //runCardToOrd();
            runFactorial();
        }

        static void TimesTable(byte number){
            WriteLine($"This is the {number} times table:");
            for(int i = 1; i <=12; i++){
                WriteLine($"{i} x {number} = {i * number}");
            }
            WriteLine();
        }

        static void RunTimesTable(){
            bool isNumber;
            do {
                Write($"Number between 0 and 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);

                if(isNumber){
                    TimesTable(number);
                }
                else {
                    WriteLine("Invalid Number");
                }
            }
            while(isNumber);
        }

        static decimal CalcTax(decimal amount, string regioncode){
            decimal rate = 0.0M;
            switch (regioncode)
            {
                case "CH": // Switzerland 
                rate = 0.08M;
                break;
                case "DK": // Denmark 
                case "NO": // Norway
                rate = 0.25M;
                break;
                case "GB": // United Kingdom
                case "FR": // France
                rate = 0.2M;
                break;
                case "HU": // Hungary
                rate = 0.27M;
                break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                rate = 0.0M; break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maine
                case "VA": // Virginia
                rate = 0.05M;
                break;
                case "CA": // California
                rate = 0.0825M;
                break;
                default: // most US states 
                rate = 0.06M;
                break;
            }
            return amount * rate;    
        }

        static void RunCalcTax(){
            Write("Enter amount: ");
            string amountintext = ReadLine();
            Write("Region Code: ");
            string region = ReadLine();

            if(decimal.TryParse(amountintext, out decimal amount)){
                decimal tax = CalcTax(amount, region);
                WriteLine($"You must pay {tax:N0}");
            }     
            else {
                WriteLine("Invalid amount");
            }
            
        }
/// <summary>
/// Pass a number in
/// </summary>
/// <param name="number">cardinal number 1,2,3</param>
/// <returns></returns>
        static string cardToOrd(int number){
            switch (number)
            {
            case 11:
            case 12:
            case 13:
            return $"{number}th";
            default:
            string numberAsText = number.ToString();
            char lastDigit = numberAsText[numberAsText.Length - 1];
            string suffix = string.Empty;
            switch (lastDigit)
            {
                case '1':
                suffix = "st";
                break;
                case '2':
                suffix = "nd";
                break;
                case '3':
                suffix = "rd";
                break;
                default:
                suffix = "th";
                break;
            }
            return $"{number}{suffix}";
            }
        } 

        static void runCardToOrd(){
            for(int i = 1; i <= 40; i++){
                Write($"{cardToOrd(i)} ");
            }
            WriteLine();
        }

        static int Factorial(int number){
            if(number < 1){
                return 0;
            }
            else if(number == 1){
                return 1;
            }
            else {
                return number * Factorial(number - 1);
            }
        }

        static void runFactorial(){
            bool isNumber;
            do {
                Write("Enter number: ");
                isNumber = int.TryParse(ReadLine(), out int number);

                if(isNumber){
                    WriteLine($"{number:N0}! = {Factorial(number):N0}");
                }
            }
            while(isNumber);
        }

    }
}
