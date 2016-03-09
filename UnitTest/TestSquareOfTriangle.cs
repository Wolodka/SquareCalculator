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
    public class TestSquareOfTriangle
    {
        [TestMethod]
        public void CalcSquareOfTriangle()
        {
            double  site1Length = 5d,
                    site2Length = 3d,
                    site3Length = 7d;

            double square = new TriangleSquareCalculator(site1Length, site2Length, site3Length).Calc();

            Assert.AreEqual(6.5, Math.Round(square, 1));
        }
    }
}
