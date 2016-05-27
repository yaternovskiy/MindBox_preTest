using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox_preTest;

namespace UnitTests
{
    [TestClass]
    public class UnitTestsCalculation
    {
        // Here I have to somehow mock the static constant and validation method. But I'll do it later.

        [TestMethod]
        public void AreaCalcCorrect() // runs with different args' types
        {
            var actual = Calculator.TriangleArea3Sides(3, 4.0F, 5.0);
            Assert.AreEqual(6.0, actual);
        }

        [TestMethod]
        public void AreaCalcFail() // returns 0 if validation fail
        {
            var actual = Calculator.TriangleArea3Sides(0, 4.0F, 5.0);
            Assert.AreEqual(0, actual);
        }
    }

    [TestClass]
    public class UnitTestsValidation
    {
        [TestMethod]
        public void TestTriangleValidationOK() // Valid, OK and corresponds to Pifagor rule with given deviation
        {
            var values = new double[] { 1.0, 2.0, 2.23 };
            var actual = Calculator.IsValidTriangle(values);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestTriangleValidationFail1() // Invalid: 0 arguments
        {
            var values = new double[0];
            var actual = Calculator.IsValidTriangle(values);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestTriangleValidationFail2() // Invalid: 4 arguments
        {
            var values = new double[0];
            var actual = Calculator.IsValidTriangle(values);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestTriangleValidationFail3() // Invalid: negative value
        {
            var values = new double[] { 1.0, -2.0, 2.23 };
            var actual = Calculator.IsValidTriangle(values);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestTriangleValidationFail4() // Invalid: zero value
        {
            var values = new double[] { 1.0, 0, 2.23 };
            var actual = Calculator.IsValidTriangle(values);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestTriangleValidationFailPifagor() // Invalid: Pifagor rule
        {
            var values = new double[] { 1.0, 2.0, 2.1 };
            var actual = Calculator.IsValidTriangle(values);
            Assert.AreEqual(false, actual);
        }
    }
}
