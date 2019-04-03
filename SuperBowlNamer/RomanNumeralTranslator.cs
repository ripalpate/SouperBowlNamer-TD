using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBowlNamer
{
    public class RomanNumeralTranslator
    {
        public string TranslateToRomanNumeral(int numberToTranslate)
        {
            var result = "";
            //switch (numberToTranslate) {
            //    case 1 : return result = "I";
            //    case 5 : return result = "V";
            //    case 9 : return result = "IX";
            //    default: return result;
            //}
            if (numberToTranslate == 1)
            {
                return result += "I";
            }
            if (numberToTranslate >= 5 && numberToTranslate<9)
            {
                var counter = numberToTranslate - 5;
                result = "V";
                while(counter > 0) {
                    result += "I";
                   counter= counter - 1;
                }
                return result;
            }
            return result;
        }
    }
}
