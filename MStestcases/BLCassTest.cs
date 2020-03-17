using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MStestcases
{
    [TestClass]
    public class BLCassTest
    {
        [TestMethod]
        public void DivideTest1()
        {
            // Arrange - Declare actuals and expected

            int Numerator = 10;
            int Denominator = 2;
            int expected = 5;
            int actual = 0;

            // Act   - call the method and pass the actuals as parameters

            BLclass B = new BLclass();
            actual = B.Divide(Numerator, Denominator);

            // Assert - Check Whether actuals are  matching with expected

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTest2()
        {
            // Arrange - Declare actuals and expected

            int Numerator = 0;
            int Denominator = 2;
            int expected = 0;
   

            // Act   - call the method and pass the actuals as parameters

            BLclass B = new BLclass();
            int actual = B.Divide(Numerator, Denominator);

            // Assert - Check Whether actuals are  matching with expected

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DivideTest3()
        {
            // Arrange - Declare actuals and expected

            int Numerator = 10;
            int Denominator = 0;
            BLclass BL = new BLclass();
            var ex = Assert.ThrowsException<DivideByZeroException>(()=> BL.Divide(Numerator, Denominator));
           Assert.AreEqual("Cannot Divide by zero", ex.Message);
        }
    }
}
