using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestMyLib;

namespace Test.Tests
{
    [TestClass]
    public class InterfaceTests
    {
        [TestMethod]
        public void CircleSquare_10_314return()
        {
            int r = 10;
            string expected = "Круг 314,16";
            CircleSquare fihure = new CircleSquare();
            string actual = fihure.Sides(new double[] { r });
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TriangleSquare_3and4and5_6return()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            string expected = "Треугольник 6";
            TriangleSquare triangle = new TriangleSquare();
            string actual =triangle.Sides(new double[] { a, b, c });
            Assert.AreEqual(expected, actual);
        }

    }
}
