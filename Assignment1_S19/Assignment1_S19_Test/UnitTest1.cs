using Assignment1_S19;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment1_S19_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_NumberUtil_IsPrimeNumber()
        {
            Assert.IsTrue(
                NumberUtil.IsPrimeNumber(0) == false
                && NumberUtil.IsPrimeNumber(1) == false
                && NumberUtil.IsPrimeNumber(2) == true
                && NumberUtil.IsPrimeNumber(17) == true
                && NumberUtil.IsPrimeNumber(19) == true
                && NumberUtil.IsPrimeNumber(83) == true
            );
        }

        [TestMethod]
        public void Test_NumberUtil_GetFactorial()
        {
            Assert.IsTrue(
                NumberUtil.GetFactorial(0) == 1
                && NumberUtil.GetFactorial(1) == 1
                && NumberUtil.GetFactorial(4) == 24
                && NumberUtil.GetFactorial(5) == 120
            );

            try{
                NumberUtil.GetFactorial(-1);
            }
            catch (Exception ex){
                Assert.AreEqual(ex.Message, "Number must be a positive integer");
            }

        }

        [TestMethod]
        public void Test_NumberUtil_GetNtermInCustomSeries()
        {
            Assert.IsTrue(
                NumberUtil.GetNtermInCustomSeries(1) == 0.5
                && NumberUtil.GetNtermInCustomSeries(2) < 0
                && NumberUtil.GetNtermInCustomSeries(24) < 0
            );
        }
    }
}
