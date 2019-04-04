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

        [Fact]
        public void number_9_should_translate_to_roman_numeral_IX()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 9;
            var expectedResult = "IX";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_12_should_translate_to_roman_numeral_XII()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 12;
            var expectedResult = "XII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void number_16_should_translate_to_roman_numeral_XVI()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 16;
            var expectedResult = "XVI";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
