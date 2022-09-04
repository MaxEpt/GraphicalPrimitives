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

        public bool IsRectangular
        {
            get 
            {
                if (SideALength > SideBLength && SideALength > SideCLength)
                    return Math.Round(Math.Pow(SideALength, 2), 3) == Math.Round(Math.Pow(SideBLength, 2) + Math.Pow(SideCLength, 2), 3);
                else if (SideBLength > SideCLength)
                    return Math.Round(Math.Pow(SideBLength, 2), 3) == Math.Round(Math.Pow(SideALength, 2) + Math.Pow(SideCLength, 2), 3);
                else
                    return Math.Round(Math.Pow(SideCLength, 2), 3) == Math.Round(Math.Pow(SideALength, 2) + Math.Pow(SideBLength, 2), 3);
            }
        }

        public Triangle(double sideALength, double sideBLength, double sideCLength)
        {
            if (!(sideALength + sideBLength > sideCLength) ||
                !(sideALength + sideCLength > sideBLength) ||
                !(sideBLength + sideCLength > sideALength))
            {
                throw new ArgumentException("Sides length is incorrect");
            }

            SideALength = sideALength;
            SideBLength = sideBLength;
            SideCLength = sideCLength;
        }

        public override double CalculateArea()
        {
            double halfPerimeter = (SideALength + SideBLength + SideCLength) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideALength) * (halfPerimeter - SideBLength) * (halfPerimeter - SideCLength));
        }
    }
}
