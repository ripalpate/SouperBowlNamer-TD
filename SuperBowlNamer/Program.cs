using System;

namespace SuperBowlNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number between 0 and 3999");
            var input = Console.ReadLine();
            var convertedInputToNumber = Convert.ToInt16(input);
            var ConvertToRoman = new RomanNumeralTranslator();
            var result = ConvertToRoman.TranslateToRomanNumeral(convertedInputToNumber);
            Console.WriteLine($"Roman number is {result}");
            Console.ReadLine();
        }
    }
}
