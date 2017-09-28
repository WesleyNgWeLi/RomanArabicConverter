using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanArabicConverter
{
    public class ArabicHelper
    {
        //mapping of digit to letters
        private string[] thArabic = { "", "M", "MM", "MMM" };
        private string[] hArabic =
            { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private string[] teArabic =
            { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private string[] oArabic =
            { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        /// <summary>
        /// Takes arabic input and outputs roman string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string DoArabic(int input)
        {
            string res = "";
            int temp;
            try
            {
                //start with isolating thousands, convert thousands digit to arabic, removes the thousand from input
                temp = input / 1000;
                res += thArabic[temp];
                input %= 1000;

                //isolating hundreds, convert hundreds digit to arabic, removes the hundreds from input
                temp = input / 100;
                res += hArabic[temp];
                input %= 100;

                //isolating tens, convert tens digit to arabic, removes the tens from input
                temp = input / 10;
                res += teArabic[temp];
                input %= 10;

                //input should be left in the singles/ones
                res += oArabic[input];
            }
            catch
            {
                return "";
            }

            return res;
        }

}
}
