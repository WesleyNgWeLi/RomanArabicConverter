using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanArabicConverter
{
    public class RomanHelper
    {
        public RomanDictModel RDM;

        public int DoRoman(string input)
        {
            RDM = new RomanDictModel();
            int res = 0;
            input = input.ToUpper();
            if(input.Length == 0)
            {
                return 0;
            }

            //for(int i = 0; i < input.Length; i++)
            //{
            //    String n = input[i].ToString();
            //    if(CheckCXI(input[i]))
            //    {
            //        if (i != input.Length-1 && !CheckCXI(input[i + 1]))
            //        {
            //            i++;
            //            n += input[i].ToString();
            //            res += RDM.romanMap[n];
            //        }
            //        else
            //        {
            //            res += RDM.romanMap[n];
            //        }
            //    }
            //    else
            //    {
            //        res += RDM.romanMap[n];
            //    }
            //}
            int oldVal = 0;
            for (int i = input.Length - 1; i>=0; i--)
            {
                int newVal = RDM.romanMap[input[i]];

                if(newVal < oldVal)
                {
                    res -= newVal;
                }
                else
                {
                    res += newVal;
                    oldVal = newVal;
                }
            }
            return res;
        }

        public bool CheckCXI(char c)
        { return c == 'C' || c == 'X' || c == 'I'; }
    }
}
