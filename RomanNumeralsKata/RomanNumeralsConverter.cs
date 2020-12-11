using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsKata
{
    public class RomanNumeralsConverter
    {
        private Dictionary<int, string> RomanNumeralEquivalents = new Dictionary<int, string>()
        {
            {100, "C"},
            {90, "XC"},
            {50, "L" },
            {40, "XL"},
            {10, "X" },
            {9, "IX" },
            {5, "V"  },
            {4, "IV" },
            {1, "I"  },
        };


        public string ToRomanNumerals(int number)
        {
            var romanNumeral = new StringBuilder();

            foreach (var numeral in RomanNumeralEquivalents)
            {
                while (number >= numeral.Key)
                {
                    romanNumeral.Append(numeral.Value);
                    number -= numeral.Key;
                }
            }
            return romanNumeral.ToString();     
        }
    }
}
