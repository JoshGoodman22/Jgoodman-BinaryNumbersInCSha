using System;

namespace Jgoodman_BinaryNumbersInCSha
{
    class Program
    {
        static void Main(string[] args)
        {
           char ch;
           ch = 'A';
           Console.WriteLine($"ch is the storing value: {ch}");

           int ch_decimal;
           ch_decimal = ch;
           Console.WriteLine($"The decimal Value of ch is: {ch_decimal}");

           int ToConvert;
           Console.WriteLine("Enter An Interger: ");
           ToConvert = int.Parse(Console.ReadLine());

           char asChar;
           asChar = (char)ToConvert;
           Console.WriteLine($"The integer {ToConvert} cast to a char {asChar}");

           char b;
           b = (char) ('A' + 1);
           Console.WriteLine($"'a'+ 1 = {b}");

        
     

        }
    }
}
