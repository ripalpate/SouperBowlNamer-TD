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
