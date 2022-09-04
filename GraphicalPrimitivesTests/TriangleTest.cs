using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphicalPrimitives;
using System;

namespace GraphicalPrimitivesTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Test_CalculateArea()
        {
            var triangle = new Triangle(2, 2, 2);
            double expectedArea = 1.732;

            Assert.AreEqual(expectedArea, Math.Round(triangle.CalculateArea(), 3));
        }

        [TestMethod]
        public void Test_Constructor_ThrowsExceperion_If_SidesLen_IsIncorrect()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 2, 15), "Greatest side C");
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 15, 2), "Greatest side B");
            Assert.ThrowsException<ArgumentException>(() => new Triangle(15, 2, 2), "Greatest side A");
        }

        [TestMethod]
        public void Test_IsRectangular()
        {
            var rectengularTriangle = new Triangle(10, 6, 8);
            Assert.IsTrue(rectengularTriangle.IsRectangular);

            var notRectengularTriangle = new Triangle(10, 6, 9);
            Assert.IsFalse(notRectengularTriangle.IsRectangular);
        }
    }
}