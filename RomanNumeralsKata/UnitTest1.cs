using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Xunit;

namespace RomanNumeralsKata
{
    public class RomanNumeralsTest
    {
        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(17, "XVII")]
        [InlineData(20, "XX")]
        [InlineData(21, "XXI")]
        [InlineData(29, "XXIX")]
        [InlineData(30, "XXX")]
        [InlineData(34, "XXXIV")]
        [InlineData(39, "XXXIX")]
        [InlineData(40, "XL")]
        [InlineData(41, "XLI")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        [InlineData(51, "LI")]
        [InlineData(54, "LIV")]
        [InlineData(59, "LIX")]
        [InlineData(60, "LX")]
        [InlineData(70, "LXX")]
        [InlineData(88, "LXXXVIII")]
        [InlineData(90, "XC")]
        [InlineData(100, "C")]
        [InlineData(200, "CC")]

        public void acceptsNumber_ReturnsRomanNumeral(int number, string romanNumeral)
        {
            var converter = new RomanNumeralsConverter();

            var result = converter.ToRomanNumerals(number);

            Assert.Equal(romanNumeral, result);
        }
    }
}
