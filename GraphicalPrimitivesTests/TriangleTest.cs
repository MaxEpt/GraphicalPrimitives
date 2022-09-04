using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphicalPrimitives;
using System;

namespace GraphicalPrimitivesTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestCalculateArea()
        {
            var triangle = new Triangle(2, 2, 2);
            double expectedArea = 1.732;

            Assert.AreEqual(expectedArea, Math.Round(triangle.CalculateArea(), 3));
        }
    }
}