// See https://aka.ms/new-console-template for more information
using GraphicalPrimitives;
using Example;

List<GraphicalPrimitive> primitives = new List<GraphicalPrimitive>();

var triangle = new Triangle(2, 2, 2);
primitives.Add(triangle);

var circle = new Circle(10);
primitives.Add(circle);

foreach (var primitive in primitives)
{
    Console.WriteLine(primitive.CalculateArea());
}
