using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            ValuesHolder holder = new ValuesHolder();
            holder.PropertyChanged += Holder_PropertyChanged;

            holder.ArabicValue = 10;


            RDM = new RomanDictModel();
            int res = 0;
            input = input.ToUpper();
            if(input.Length == 0)
            {
                return 0;
            }

            //wanted to try to be fancy and build a smarter algorithm
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
            //parses from the back forward
            for (int i = input.Length - 1; i>=0; i--)
            {
                 int newVal = RDM.romanMap[input[i]];
                //if the next value is a 1/10/100 prior to a 5/10/50/100/500/1000
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

        private void Holder_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }

        public bool CheckCXI(char c)
        { return c == 'C' || c == 'X' || c == 'I'; }
    }
}

public class ValuesHolder : INotifyPropertyChanged
{
    private string _romanValue;
    public string RomanValue
    {
        get
        {
            return _romanValue;
        }
        set
        {
            if (value != _romanValue)
            {
                _romanValue = value;
                PropertyChangedHandler("RomanValue");
            }
        }
    }

    private int _arabicValue;
    public int ArabicValue
    {
        get
        {
            return _arabicValue;
        }
        set
        {
            if (value != _arabicValue)
            {
                _arabicValue = value;
                PropertyChangedHandler("ArabicValue");
            }
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;

    public void SetArabicValue(int value)
    {
        _arabicValue = value;
    }

    public void SetRomanValue(string value)
    {
        // Validate, if invalid throw exception or set to -
        _romanValue = value;
    }

    public void PropertyChangedHandler(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
