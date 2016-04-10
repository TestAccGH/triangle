using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace UnitTestTriangleSquare
{
    [TestClass]
    public class TriangleSquareUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSquare_ParamLessThenZero_ArgumentException()
        {
            double a = -1, b = 10, c = 5;
            Triangle.Triangle.GetSquare(a, b, c);
        }
        [TestMethod]
        public void GetSquare_BigParams_Infinity()
        {
            double a = Double.MaxValue;
            double b = Double.MaxValue;
            double c = 1;
            var res= Triangle.Triangle.GetSquare(a, b, c);
            Assert.AreEqual(double.PositiveInfinity, res);
        }

        [TestMethod]
        public void GetSquare_AlmostBigParams_Result()
        {
            double a = Double.MaxValue-1;
            double b = Double.MaxValue-1;
            double c = 1;
            var res = Triangle.Triangle.GetSquare(a, b, c);
            Assert.AreEqual(double.PositiveInfinity, res);
        }

        [TestMethod]
        public void GetSquare_ActualParams_Result()
        {
            double a = 1, b = 1, c = 1;
            var res = Triangle.Triangle.GetSquare(a, b, c);
            Assert.AreEqual(0.43, res, 0.1);
        }
    }
}
