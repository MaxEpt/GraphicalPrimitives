using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicalPrimitives;

namespace Example
{
    internal class Circle : GraphicalPrimitive
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;    
        }
    }
}
