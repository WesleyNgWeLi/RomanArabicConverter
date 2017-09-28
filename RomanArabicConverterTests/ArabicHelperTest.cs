using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanArabicConverter;

namespace RomanArabicConverterTests
{
    [TestClass]
    public class ArabicHelperTest
    {
        ArabicHelper AH;

        [TestInitialize]
        public void SetUp()
        {
            AH = new ArabicHelper();
        }

        [TestMethod]
        public void DoArabicShouldReturnMMMCMXCIXifInputIs3999()
        {
            var res = AH.DoArabic(3999);
            Assert.IsTrue(res == "MMMCMXCIX");
        }

        [TestMethod]
        public void DoArabicShouldReturnNothingIf0Input()
        {
            var res = AH.DoArabic(0);
            Assert.IsTrue(res == "");
        }

        [TestMethod]
        public void DoArabicShouldReturnMifInputIs1000()
        {
            var res = AH.DoArabic(1000);
            Assert.IsTrue(res == "M");
        }

        [TestMethod]
        public void DoArabicShouldReturnMCMLXXXIXifInputIs1989()
        {
            var res = AH.DoArabic(1989);
            Assert.IsTrue(res == "MCMLXXXIX");
        }

        [TestMethod]
        public void DoArabicShouldReturnIifInputIs1()
        {
            var res = AH.DoArabic(1);
            Assert.IsTrue(res == "I");
        }

        [TestMethod]
        public void DoArabicShouldReturnIIIifInputIs3()
        {
            var res = AH.DoArabic(3);
            Assert.IsTrue(res == "III");
        }

        [TestMethod]
        public void DoArabicShouldReturnIXifInputIs9()
        {
            var res = AH.DoArabic(9);
            Assert.IsTrue(res == "IX");
        }

        [TestMethod]
        public void DoArabicShouldReturnMLXVIifInputIs1066()
        {
            var res = AH.DoArabic(1066);
            Assert.IsTrue(res == "MLXVI");
        }

        [TestMethod]
        public void DoArabicShouldReturnBlankIfInputIsOver3999()
        {
            var res = AH.DoArabic(4000);
            Assert.IsTrue(res == "");
        }
    }
}
