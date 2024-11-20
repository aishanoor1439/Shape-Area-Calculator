using System;

class Shape_Area_Calculator
{
    static void Main()
    {
        // Prompt the user to select a shape
        Console.WriteLine("Select a shape to calculate the area:");
        Console.WriteLine("C for Circle, R for Rectangle, T for Triangle, S for Sphere (Surface Area), P for Pyramid (Base Area), H for Hexagon");
        char shape = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        switch (shape)
        {
            case 'C':
                // Circle Area: π * r^2
                Console.Write("Enter the radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double circleArea = 3.14 * radius * radius;
                Console.WriteLine("The area of the circle is: {0}", circleArea);
                break;

            case 'R':
                // Rectangle Area: length * width
                Console.Write("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                double width = Convert.ToDouble(Console.ReadLine());
                double rectangleArea = length * width;
                Console.WriteLine("The area of the rectangle is: {0}", rectangleArea);
                break;

            case 'T':
                // Triangle Area: (base * height) / 2
                Console.Write("Enter the base of the triangle: ");
                double triangleBase = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height of the triangle: ");
                double height = Convert.ToDouble(Console.ReadLine());
                double triangleArea = (triangleBase * height) / 2;
                Console.WriteLine("The area of the triangle is: {0}", triangleArea);
                break;

            case 'S':
                // Sphere Surface Area: 4 * π * r^2
                Console.Write("Enter the radius of the sphere: ");
                double sphereRadius = Convert.ToDouble(Console.ReadLine());
                double sphereArea = 4 * 3.14 * sphereRadius * sphereRadius;
                Console.WriteLine("The surface area of the sphere is: {0}", sphereArea);
                break;

            case 'P':
                // Pyramid Base Area: length * width (assuming rectangular base)
                Console.Write("Enter the length of the pyramid base: ");
                double pyramidLength = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the width of the pyramid base: ");
                double pyramidWidth = Convert.ToDouble(Console.ReadLine());
                double pyramidBaseArea = pyramidLength * pyramidWidth;
                Console.WriteLine("The base area of the pyramid is: {0}", pyramidBaseArea);
                break;

            case 'H':
                // Hexagon Area: (3√3 * s^2) / 2
                Console.Write("Enter the length of a side of the hexagon: ");
                double side = Convert.ToDouble(Console.ReadLine());
                double hexagonArea = (3 * 1.732 * side * side) / 2;
                Console.WriteLine("The area of the hexagon is: {0}", hexagonArea);
                break;

            default:
                Console.WriteLine("Invalid shape selection. Please enter C, R, T, S, P, or H.");
                break;
        }
    }
}
