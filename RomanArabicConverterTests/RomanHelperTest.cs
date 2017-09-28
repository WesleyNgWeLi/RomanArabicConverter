using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanArabicConverter;

namespace RomanArabicConverterTests
{
    [TestClass]
    public class RomanHelperTest
    {
        RomanHelper RH;
        RomanDictModel RDM;

        [TestInitialize]
        public void SetUp()
        {
            RH = new RomanHelper();
            RDM = new RomanDictModel();
        }

        [TestMethod]
        public void DoRomanShouldReturn900IfInputCM()
        {
            var res = RH.DoRoman("CM");
            Assert.IsTrue(res == 900);
        }

        [TestMethod]
        public void DoRomanShouldReturn3999IfInputMMMCMXCIX()
        {
            var res = RH.DoRoman("MMMCMXCIX");
            Assert.IsTrue(res == 3999);
        }

        [TestMethod]
        public void DoRomanShouldReturn1989IfInputMCMLXXXIX()
        {
            var res = RH.DoRoman("MCMLXXXIX");
            Assert.IsTrue(res == 1989);
        }

        [TestMethod]
        public void DoRomanShouldReturn1066IfInputMLXVI()
        {
            var res = RH.DoRoman("MLXVI");
            Assert.IsTrue(res == 1066);
        }

        [TestMethod]
        public void DoRomanShouldReturn9IfInputIX()
        {
            var res = RH.DoRoman("IX");
            Assert.IsTrue(res == 9);
        }

        [TestMethod]
        public void DoRomanShouldReturn3IfInputIII()
        {
            var res = RH.DoRoman("III");
            Assert.IsTrue(res == 3);
        }

        [TestMethod]
        public void DoRomanShouldReturn1IfInputI()
        {
            var res = RH.DoRoman("I");
            Assert.IsTrue(res == 1);
        }
    }
}
