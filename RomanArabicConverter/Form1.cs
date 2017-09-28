using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanArabicConverter
{
    public partial class Form1 : Form
    {
        RomanHelper RH;
        ArabicHelper AH;

        ValuesHolder valuesHolder = new ValuesHolder();

        public Form1()
        {
            InitializeComponent();
            valuesHolder.PropertyChanged += ValuesHolder_PropertyChanged;

            tbRoman.DataBindings.Add(new Binding("Text", valuesHolder, "RomanValue", false, DataSourceUpdateMode.OnPropertyChanged));
            tbArabic.DataBindings.Add(new Binding("Text", valuesHolder, "ArabicValue", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void ValuesHolder_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "ArabicValue":
                    var arabicValue = ((ValuesHolder)sender).ArabicValue;

                    AH = new ArabicHelper();
                    var result = AH.DoArabic(arabicValue);

                    ((ValuesHolder)sender).SetRomanValue(result);

                    break;
                case "RomanValue":

                    var romanValue = ((ValuesHolder)sender).RomanValue;

                    RH = new RomanHelper();
                    var res =  RH.DoRoman(romanValue);

                    ((ValuesHolder)sender).SetArabicValue(res); //res.ToString();
                    break;
            }
        }

        private void tbRoman_TextChanged(object sender, EventArgs e)
        {
            //RH = new RomanHelper();
            //if (tbRoman.Text != "")
            //{
            //    tbArabic.Text = RH.DoRoman(tbRoman.Text).ToString();
            //}
        }

        private void tbArabic_TextChanged(object sender, EventArgs e)
        {
            //AH = new ArabicHelper();
            //if (tbArabic.Text != "")
            //{
            //    string res = AH.DoArabic(Convert.ToInt32(tbArabic.Text));
            //    tbRoman.Text = res;
            //}
        }
    }
}
