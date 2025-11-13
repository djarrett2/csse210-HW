using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square s1 = new Square(5, "blue");
        shapes.Add(s1);
        //Console.WriteLine(s1.GetColor());
        //Console.WriteLine(s1.GetArea());

        Rectangle r1 = new Rectangle(8, 4, "orange");
        shapes.Add(r1);
        //Console.WriteLine(r1.GetColor());
        //Console.WriteLine(r1.GetArea());


        Circle c1 = new Circle(6, "yellow");
        shapes.Add(c1);
        //Console.WriteLine(c1.GetColor());
        //Console.WriteLine(c1.GetArea());

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());  
        }
            
    }
}