using System;
using ShapeAreaLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string decision;

            do
            {
                Console.WriteLine("Welcome to the project!!!");
                Console.WriteLine("choose a shape to calculate it's area:");
                Console.WriteLine("Enter your choice: \n 1.Rectangle \n 2.Square \n 3.Circle \n 4.Triangle");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter height of the rectangle: ");
                            double rectangleHeight = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter width of the rectangle");
                            double rectangleWidth = double.Parse(Console.ReadLine());

                            Rectangle rectangle = new Rectangle();
                            double rectangleArea = rectangle.Area(rectangleHeight, rectangleWidth);
                            Console.WriteLine($"Area of rectangle is: {rectangleArea}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the length of the square: ");
                            double squareSide = double.Parse(Console.ReadLine());

                            Square square = new Square();
                            double squareArea = square.Area(squareSide);
                            Console.WriteLine($"Area of the square is: {squareArea}");
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the radius of the circle:");
                            double circleRadius = double.Parse(Console.ReadLine());

                            Circle circle = new Circle();
                            double circleArea = circle.Area(circleRadius);
                            Console.WriteLine($"Area of the circle is: {circleArea}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter baseLength of Triangle:");
                            double triangleBaseLength = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter height of the Triangle:");
                            double triangleHeight = double.Parse(Console.ReadLine());

                            Triangle triangle = new Triangle();
                            double triangleArea = triangle.Area(triangleBaseLength, triangleHeight);
                            Console.WriteLine($"Area of the Triangle is: {triangleArea}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice!!!");
                            break;

                        }
                }
                Console.WriteLine("press y to continue");
                decision = Console.ReadLine().ToLower();
            } while (decision == "y");
            Console.ReadKey();
                    
        }    
    }
}
