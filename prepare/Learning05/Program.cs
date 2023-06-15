using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine(" ----- Individual Test ------");
        Square square =new Square( "green", 3);
        square.GetArea();
        Rectangle rectangle =new Rectangle( "orange", 3 , 2);
        rectangle.GetArea();
        Circle circle =new Circle( "blue", 3);
        circle.GetArea();
        //test individual
        Console.WriteLine($"Area Square (Green,3): {square.GetArea().ToString("#.##")} and Color: {square.GetColor()}");
        Console.WriteLine($"Area Rectanle (Orange,3,2): {rectangle.GetArea().ToString("#.##")} and Color: {rectangle.GetColor()}");
        Console.WriteLine($"Area Circle (Blue,3): {circle.GetArea().ToString("#.##")} and Color: {circle.GetColor()}");
        // Step 7 create a list
        Console.WriteLine("");
        Console.WriteLine(" ----- Polymorphism Test ------");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach ( Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine($"Area: {area.ToString("#.##")} and Color: {shape.GetColor()}");
        }

        Console.WriteLine("");
        // Using Display
        DisplayShapeArea(square);
        DisplayShapeArea(rectangle);
        DisplayShapeArea(circle);

        static void DisplayShapeArea(Shape shape)
        {
            double area = shape.GetArea();
            Console.WriteLine($"Display Area: {area.ToString("#.##")} and Color: {shape.GetColor()}");
        }



    }
}

