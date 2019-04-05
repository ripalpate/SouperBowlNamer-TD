using System;

namespace SuperBowlNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            var input = Console.ReadLine();
            var converted = Convert.ToInt16(input);
            var ConvertToRoman = new RomanNumeralTranslator();
            var result = ConvertToRoman.TranslateToRomanNumeral(converted);
            Console.WriteLine($"Roman number is {result}");
            Console.ReadLine();
        }
    }
}
