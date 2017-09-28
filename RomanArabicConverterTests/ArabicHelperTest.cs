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
        public void DoArabicShouldReturnBlankIfInputIsOver3999()
        {
            var res = AH.DoArabic(4000);
            Assert.IsTrue(res == "");
        }
    }
}
