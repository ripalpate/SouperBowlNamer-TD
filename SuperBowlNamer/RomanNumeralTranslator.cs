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
            while (counter > 0)
            {
                if (counter >= 50) { result += "L"; counter -= 50; }
                else if (counter >= 40) { result += "XL"; counter -= 40; }
                else if (counter >= 10) { result +="X"; counter -= 10; }
                else if (counter >= 9) { result +="IX"; counter -= 9; }
                else if (counter >= 5) { result +="V"; counter -= 5; }
                else if (counter >= 4) { result +="IV"; counter -= 4; }
                else if (counter >= 1) { result +="I"; counter -= 1; }
            }
            return result;
        }
    }
}
