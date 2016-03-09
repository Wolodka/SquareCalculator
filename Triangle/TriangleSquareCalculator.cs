using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Triangle
{
    public class TriangleSquareCalculator
    {
        private double _site1Length;
        private double _site2Length;
        private double _site3Length;
        private double _halfPerimeter;

        public TriangleSquareCalculator(
            double site1Length,
            double site2Length,
            double site3Length)
        {
            _site1Length = site1Length;
            _site2Length = site2Length;
            _site3Length = site3Length;
        }

        public double Calc()
        {
            CalcHalfPerimeter();

            return CalcSquareByGeronsFormula();
        }

        private void CalcHalfPerimeter()
        {
            _halfPerimeter = 0.5 * (_site1Length + _site2Length + _site3Length);
        }

        private double CalcSquareByGeronsFormula()
        {
            return Math.Sqrt(_halfPerimeter *
                                (_halfPerimeter - _site1Length) *
                                (_halfPerimeter - _site2Length) *
                                (_halfPerimeter - _site3Length));
        }

    }
}
