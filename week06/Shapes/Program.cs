using System;

class Program
{
    static void Main(string[] args)
    {
        double areaS;
        double areaR;
        double areaC;

        string colorS;
        string colorR;
        string colorC;

        Console.WriteLine("");
        Console.WriteLine("    Shapes Program");
        Console.WriteLine("");

        Square s1 = new Square("red", 9);
        Rectangle r1 = new Rectangle("yellow", 7, 8);
        Circle c1 = new Circle("blue", 6);

        colorS = s1.GetColor();
        areaS = s1.GetArea();
        colorR = r1.GetColor();
        areaR = r1.GetArea();
        colorC = c1.GetColor();
        areaC = c1.GetArea();

        Console.WriteLine("Testing Part 1 - Creating instances & calling getter methods");
        Console.WriteLine($"Square - Color: {colorS}, Area: {areaS}");
        Console.WriteLine($"Rectangle - Color: {colorR}, Area: {areaR}");
        Console.WriteLine($"Circle - Color: {colorC}, Area: {areaC}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        Console.WriteLine("");
        Console.WriteLine("Testing Part 2 - Iterating through the List");

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            Console.WriteLine($"Color: {color}");
            double area = shape.GetArea();
            Console.WriteLine($"Area: {area}");
        }

        Console.WriteLine("");
    }
}