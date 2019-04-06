using System;

namespace SuperBowlNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;
            while (!exit)
            {
                var userInput = MainMenu();
                exit = TakeActions(userInput);
            }
        }
        internal static ConsoleKeyInfo MainMenu()
        {
            View mainMenu = new View()
                    .AddMenuOption("Do You want to convert Roman Numeral to Number? Convert it here.")
                    .AddMenuOption("Do you want to convert numbers to Roman numeral? Convert it here.")
                    .AddMenuText("Press Esc to exit.");
            Console.Write(mainMenu.GetFullMenu());
            var userOption = Console.ReadKey();
            return userOption;
        }

        private static bool TakeActions(ConsoleKeyInfo userInput)
        {
            Console.Write(Environment.NewLine);

            if (userInput.Key == ConsoleKey.Escape)
                return true;

            var selection = userInput.KeyChar.ToString();
            switch (selection)
            {
                case "1":
                    NumberToRomanNumeral();
                    break;
                case "2":
                    RomanToNumber();
                    break;
                default: return true;
            }
            return false;
        }

        internal static void NumberToRomanNumeral()
        {
            Console.WriteLine("Please enter the number between 0 and 3999");
            var input = Console.ReadLine();
            var convertedInputToNumber = Convert.ToInt16(input);
            try
            {
                if (0 >= convertedInputToNumber || convertedInputToNumber > 4000) throw new InvalidInputException();
                var ConvertToRoman = new RomanNumeralTranslator();
                var result = ConvertToRoman.TranslateToRomanNumeral(convertedInputToNumber);
                Console.WriteLine($"Roman number is {result}");
                Console.ReadLine();
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        internal static void RomanToNumber()
        {
            try
            {
                Console.WriteLine("Please enter Roman Numeral");
                var input = Console.ReadLine();
                var ConvertToNumber = new NumberCoverter();
                var result = ConvertToNumber.ConvertRomanNumeralToNumber(input);
                Console.WriteLine($"Converted number is {result}");
                Console.ReadLine();
            }
            catch (InvalidInputException)
            {
                Console.WriteLine("Please enter roman numerals between 0 and 3999");
                Console.ReadLine();
            }
        }

    }
}
