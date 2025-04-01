namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle
            // Triangle
            // Rectangle
            // Pentagon
            // Octagon

            Console.WriteLine("Area of Circle: " + AreaOfCircle(5));
            Console.WriteLine("Area of Triangle: " + AreaOfTriangle(10, 6));
            Console.WriteLine("Area of Rectangle: " + AreaOfRectangle(8, 4));
            Console.WriteLine("Area of Pentagon: " + AreaOfPentagon(7, 5));
            Console.WriteLine("Area of Octagon: " + AreaOfOctagon(6));
        }
        
        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
        static double AreaOfTriangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
        
        static int areaOfRectangle()//Add the parameters
        {
            return length * width;
        }
        
        static double AreaOfPentagon(double side, double apothem)
        {
            return (5 * side * apothem) / 2;
        }

        static double AreaOfOctagon(double side)
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(side, 2);
        }
    }
}
