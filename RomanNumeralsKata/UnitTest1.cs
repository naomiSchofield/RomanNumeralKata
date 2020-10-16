using System.Globalization;
using System.Text;
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
       

        public void acceptsNumber_ReturnsRomanNumeral(int number, string romanNumeral)
        {
            var converter = new RomanNumeralsConverter();

            var result = converter.ToRomanNumerals(number);

            Assert.Equal(romanNumeral, result);
        }
    }

    public class RomanNumeralsConverter
    {
        public string ToRomanNumerals(int number)
        {
            var romanNumeral = new StringBuilder();


            if ( number >= 10 )
            {
                romanNumeral.Append("X");
                number -= 10;
            }

            if (number >= 10)
            {
                var returnValue = ToRomanNumerals(number);
                romanNumeral.Append(returnValue);
            }
            else
            {
                var unit = ToRomanNumeralLessThan10(number);
                 romanNumeral.Append(unit);
            }
                
            return romanNumeral.ToString();     
        }


        public string ToRomanNumeralLessThan10(int number)
        {
           
            var romanNumeral = new StringBuilder();
            

            if (number < 4)
            {
                for (int j = 0; j < number; j++)
                {
                    romanNumeral.Append("I");
                }
            }

            if (number == 4)
            {
                romanNumeral.Append("IV");
            }

            if (number == 5)
            {
                romanNumeral.Append("V");
            }

            if (number > 5 && number < 9)
            {
                romanNumeral.Append("V");
                for (int K = 5; K < number; K++)
                {
                    romanNumeral.Append("I");
                }
            }

            else if (number == 9)
            {
                romanNumeral.Append("IX");
            }
            return romanNumeral.ToString();
        }

    
        
    }
}
