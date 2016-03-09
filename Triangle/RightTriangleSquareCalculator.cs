using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Triangle
{
    public class RightTriangleSquareCalculator
    {
        private double _cathetus1;
        private double _cathetus2;

        public RightTriangleSquareCalculator(double cathetus1, double cathetus2)
        {
            _cathetus1 = cathetus1;
            _cathetus2 = cathetus2;
        }

        public double Calc()
        {
            return _cathetus1 * _cathetus2 / 2;
        }
    }
}
