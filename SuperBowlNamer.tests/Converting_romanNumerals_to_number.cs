using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SuperBowlNamer.tests
{
    public class Converting_romanNumerals_to_number
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("IX", 9)]
        [InlineData("XII", 12)]
        [InlineData("XVI", 16)]
        [InlineData("XXIX", 29)]
        [InlineData("XLIV", 44)]
        [InlineData("XLV", 45)]
        [InlineData("LXVIII", 68)]
        [InlineData("LXXXIII", 83)]
        [InlineData("XCVII", 97)]
        [InlineData("XCIX", 99)]
        [InlineData("D", 500)]
        [InlineData("DI", 501)]
        [InlineData("DCXLIX", 649)]
        [InlineData("DCCXCVIII", 798)]
        [InlineData("DCCCXCI", 891)]
        [InlineData("M", 1000)]
        [InlineData("MIV", 1004)]
        [InlineData("MVI", 1006)]
        [InlineData("MXXIII", 1023)]
        [InlineData("MMXIV", 2014)]
        [InlineData("MMMCMXCIX", 3999)]
        public void romanNumerals_should_translate_to_number(string input, int expectedResult)
        {
            //Arrange
            var translator = new NumberCoverter();
            //Act
            var actualResult = translator.ConvertRomanNumeralToNumber(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
