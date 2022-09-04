using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalPrimitives
{
    public class Triangle: GraphicalPrimitive
    {
        public double SideALength;

        public double SideBLength;

        public double SideCLength;

        public bool IsRectangular { get => false; }

        public Triangle(double sideALength, double sidebLength, double sideCLength)
        {
            SideALength = sideALength;
            SideBLength = sidebLength;
            SideCLength = sideCLength;
        }

        public override double CalculateArea()
        {
            return 0;
        }
    }
}
