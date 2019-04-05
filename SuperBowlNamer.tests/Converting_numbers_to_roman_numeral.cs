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

        [Fact]
        public void number_29_should_translate_to_roman_numeral_XXIX()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 29;
            var expectedResult = "XXIX";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_44_should_translate_to_roman_numeral_XLIV()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 44;
            var expectedResult = "XLIV";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_45_should_translate_to_roman_numeral_XLV()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 45;
            var expectedResult = "XLV";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_68_should_translate_to_roman_numeral_LXVIII()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 68;
            var expectedResult = "LXVIII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_83_should_translate_to_roman_numeral_LXXXIII()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 83;
            var expectedResult = "LXXXIII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_97_should_translate_to_roman_numeral_XCVII()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 97;
            var expectedResult = "XCVII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_99_should_translate_to_roman_numeral_XCIX()
        {
            //Arrange
            var translator = new RomanNumeralTranslator();
            var input = 99;
            var expectedResult = "XCIX";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
