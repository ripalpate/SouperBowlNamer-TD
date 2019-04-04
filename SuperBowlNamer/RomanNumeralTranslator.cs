using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperBowlNamer
{
    public class RomanNumeralTranslator
    {
        public string TranslateToRomanNumeral(int numberToTranslate)
        {
            var counter = numberToTranslate;
            var result = "";

            if (counter >= 9 && counter < 19)
            {
                counter = counter - 10;
                if (counter == -1)
                {
                    result += "I";
                }
                result += "X";
            }
            if (counter >= 4 && counter < 9)
            {
                 counter = counter - 5;
                if (counter == -1)
                {
                    result += "I";
                }
                result += "V";
                while (counter > 0)
                {
                    result += "I";
                    counter = counter - 1;
                }       
            }
            if (counter >= 1 && counter <= 3)
            {
                while (counter > 0)
                {
                    result += "I";
                    counter = counter - 1;
                }
                return result;
            }
            return result;
        }
    }
}
