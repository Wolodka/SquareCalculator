using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculator.Triangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.UnitTest
{
    [TestClass]
    public class TestSquareOfRightTriangle
    {
        [TestMethod]
        public void CalcSquareOfRightTriangle()
        {
            double cathetus1 = 10d;
            double cathetus2 = 15d;

            double square = new RightTriangleSquareCalculator(cathetus1, cathetus2).Calc();

            Assert.AreEqual(75d, square);
        }
    }
}
