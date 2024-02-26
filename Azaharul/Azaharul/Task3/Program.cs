using Task3;
Console.WriteLine("Choose a shape:");
Console.WriteLine("1. Rectangle");
Console.WriteLine("2. Triangle");
Console.WriteLine("3. Circle");
int choice = int.Parse(Console.ReadLine());
IShape shape;
switch (choice)
{
    case 1:
        Console.Write("Enter width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter height of the rectangle: ");
        double height = double.Parse(Console.ReadLine());

        shape = new Rectangle(width, height);
        Console.WriteLine($"Area: {shape.CalculateArea()}");
        Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
        break;

    case 2:
        Console.Write("Enter length of side 1 of the triangle: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter length of side 2 of the triangle: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter length of side 3 of the triangle: ");
        double side3 = double.Parse(Console.ReadLine());

        shape = new Triangle(side1, side2, side3);
        Console.WriteLine($"Area: {shape.CalculateArea()}");
        Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
        break;

    case 3:
        Console.Write("Enter radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        shape = new Circle(radius);
        Console.WriteLine($"Area: {shape.CalculateArea()}");
        Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
        break;

    default:
        Console.WriteLine("Invalid Choice");
        break;
}