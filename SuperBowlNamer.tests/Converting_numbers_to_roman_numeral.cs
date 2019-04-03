using System;
using Xunit;

namespace SuperBowlNamer.tests
{
    public class Converting_numbers_to_roman_numeral
    {
        [Fact]
        public void number_1_should_translate_to_roman_numeral_I()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 1;
            var expectedResult = "I";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void number_5_should_translate_to_roman_numeral_V()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 5;
            var expectedResult = "V";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
