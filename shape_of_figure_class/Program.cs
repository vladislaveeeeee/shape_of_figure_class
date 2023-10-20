using System;
using System.Collections.Specialized;
using System.Linq;

namespace Shape
{
    internal class Program
    {
        abstract class Shape
        {
            public abstract double Area();
            public abstract double Perimetr();

            public Shape()
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Create a shape of a figure"); Console.ResetColor();
            }
        }

        class Triangle : Shape
        {
            public double side1 { get; set; }
            public double side2 { get; set; }
            public double side3 { get; set; }
            public Triangle() { Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Create a Triangle"); Console.ResetColor(); }
            public void inputSide()
            {
                Console.WriteLine("Enter sides of the Triangle:");

                do
                {
                    Console.Write("Side 1: ");
                    side1 = double.Parse(Console.ReadLine());
                    if (side1 <= 0)
                    {
                        Console.WriteLine("Side cannot be negative. Please enter a non-negative value.");
                    }
                } while (side1 <= 0);

                do
                {
                    Console.Write("Side 2: ");
                    side2 = double.Parse(Console.ReadLine());
                    if (side2 <= 0)
                    {
                        Console.WriteLine("Side cannot be negative. Please enter a non-negative value.");
                    }
                } while (side2 <= 0);

                do
                {
                    Console.Write("Side 3: ");
                    side3 = double.Parse(Console.ReadLine());
                    if (side3 <= 0)
                    {
                        Console.WriteLine("Side cannot be negative. Please enter a non-negative value.");
                    }
                } while (side3 <= 0);
            }

            public void DetermineTriangleType()
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("This is an equilateral triangle.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("This is an isosceles triangle.");
                }
                else
                {
                    Console.WriteLine("This is a right-angled triangle.");
                }
            }
            public override double Area()
            {
                double piv;
                piv = (side1 + side2 + side3) / 2;
                double Area = Math.Sqrt(piv * (piv - side1) * (piv - side2) * (piv - side3));
                return Area;
            }

            public override double Perimetr()
            {
                double p;
                p = side1 + side2 + side3;
                return p;
            }
        }

        class Square : Shape
        {
            public double side1 { get; set; }
            public Square() { Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Create a Square"); Console.ResetColor(); }
            public void inputSide()
            {
                Console.WriteLine("Enter sides of the Square:");

                do
                {
                    Console.Write("Side 1: ");
                    side1 = double.Parse(Console.ReadLine());
                    if (side1 <= 0)
                    {
                        Console.WriteLine("Side cannot be negative. Please enter a non-negative value.");
                    }
                } while (side1 <= 0);

            }

            public override double Area()
            {
                return side1 * side1;
            }

            public override double Perimetr()
            {
                return 4 * side1;
            }
        }

        class Rectangle : Shape
        {
            public double side1 { get; set; }
            public double side2 { get; set; }
            public Rectangle() { Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Create a Rectangle"); Console.ResetColor(); }
            public void inputSide()
            {
                Console.WriteLine("Enter sides of the Rectangle:");

                do
                {
                    Console.Write("Side 1: ");
                    side1 = double.Parse(Console.ReadLine());
                    if (side1 <= 0)
                    {
                        Console.WriteLine("Side 1 cannot be negative. Please enter a non-negative value.");
                    }
                } while (side1 <= 0);

                do
                {
                    Console.Write("Side 2: ");
                    side2 = double.Parse(Console.ReadLine());
                    if (side2 <= 0)
                    {
                        Console.WriteLine("Side 2 cannot be negative. Please enter a non-negative value.");
                    }
                } while (side2 <= 0);

            }

            public override double Area()
            {
                return side1 * side2;
            }

            public override double Perimetr()
            {
                return 2 * (side1 + side2);
            }
        }

        class Diamond : Shape
        {
            public double side1 { get; set; }
            public Diamond() { Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Create a Diamond"); Console.ResetColor(); }
            public void inputSide()
            {
                Console.WriteLine("Enter sides of the Diamond:");

                do
                {
                    Console.Write("Side 1: ");
                    side1 = double.Parse(Console.ReadLine());
                    if (side1 <= 0)
                    {
                        Console.WriteLine("Side 1 cannot be negative. Please enter a non-negative value.");
                    }
                } while (side1 <= 0);

            }

            public override double Area()
            {
                return side1 * side1;
            }

            public override double Perimetr()
            {
                return 4 * side1;
            }
        }

        class Parallelogram : Shape
        {
            public double side1 { get; set; }
            public double side2 { get; set; }
            public Parallelogram() { Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Create a Parallelogram"); Console.ResetColor(); }
            public void inputSide()
            {
                Console.WriteLine("Enter sides of the Parallelogram:");

                do
                {
                    Console.Write("Side 1: ");
                    side1 = double.Parse(Console.ReadLine());
                    if (side1 <= 0)
                    {
                        Console.WriteLine("Side 1 cannot be negative. Please enter a non-negative value.");
                    }
                } while (side1 <= 0);

                do
                {
                    Console.Write("Side 2: ");
                    side2 = double.Parse(Console.ReadLine());
                    if (side2 <= 0)
                    {
                        Console.WriteLine("Side 2 cannot be negative. Please enter a non-negative value.");
                    }
                } while (side2 <= 0);

            }

            public override double Area()
            {
                return side1 * side2;
            }

            public override double Perimetr()
            {
                return 2 * (side1 + side2);
            }
        }

        class Trapezoid : Shape
        {
            public double side1 { get; set; }
            public double side2 { get; set; }
            public double height { get; set; }
            public Trapezoid()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Create a Trapezoid");
                Console.ResetColor();
            }

            public void inputSide()
            {
                Console.WriteLine("Enter sides of the Trapezoid:");

                do
                {
                    Console.Write("Top side: ");
                    side1 = double.Parse(Console.ReadLine());
                    if (side1 <= 0)
                    {
                        Console.WriteLine("Top side cannot be negative. Please enter a non-negative value.");
                    }
                } while (side1 <= 0);

                do
                {
                    Console.Write("Bottom side: ");
                    side2 = double.Parse(Console.ReadLine());
                    if (side2 <= 0)
                    {
                        Console.WriteLine("Bottom side cannot be negative. Please enter a non-negative value.");
                    }
                } while (side2 <= 0);

                do
                {
                    Console.Write("Height: ");
                    height = double.Parse(Console.ReadLine());
                    if (height <= 0)
                    {
                        Console.WriteLine("Height cannot be negative. Please enter a non-negative value.");
                    }
                } while (height <= 0);
            }

            public override double Area()
            {
                return (side1 + side2) * height / 2;
            }

            public override double Perimetr()
            {
                double perimeter;

                if (side1 == side2)
                {
                    perimeter = 2 * side1 + 2 * Math.Sqrt(Math.Pow(side1 - side2, 2) + Math.Pow(height, 2));
                    Console.WriteLine("This is an isosceles trapezoid.");
                }
                else
                {
                    perimeter = side1 + side2 + 2 * Math.Sqrt(Math.Pow(side1 - side2, 2) + Math.Pow(height, 2));
                    Console.WriteLine("This is a scalene trapezoid.");
                }

                return perimeter;
            }
        }

        class Circle : Shape
        {
            public double radius { get; set; }
            public Circle()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Create a Circle");
                Console.ResetColor();
            }

            public void inputSide()
            {
                Console.WriteLine("Enter the radius of the Circle:");

                do
                {
                    Console.Write("Radius: ");
                    radius = double.Parse(Console.ReadLine());
                    if (radius <= 0)
                    {
                        Console.WriteLine("Radius cannot be negative. Please enter a non-negative value.");
                    }
                } while (radius <= 0);
            }

            public override double Area()
            {
                return Math.PI * radius * radius;
            }

            public override double Perimetr()
            {
                return 2 * Math.PI * radius;
            }
        }

        class Ellipse : Shape
        {
            public double semiMajorAxis { get; set; }
            public double semiMinorAxis { get; set; }

            public Ellipse()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Create an Ellipse");
                Console.ResetColor();
            }

            public void inputSide()
            {
                Console.WriteLine("Enter the semi-major and semi-minor axes of the Ellipse:");

                do
                {
                    Console.Write("Semi-Major Axis: ");
                    semiMajorAxis = double.Parse(Console.ReadLine());
                    if (semiMajorAxis <= 0)
                    {
                        Console.WriteLine("Semi-Major Axis cannot be negative. Please enter a non-negative value.");
                    }
                } while (semiMajorAxis <= 0);

                do
                {
                    Console.Write("Semi-Minor Axis: ");
                    semiMinorAxis = double.Parse(Console.ReadLine());
                    if (semiMinorAxis <= 0)
                    {
                        Console.WriteLine("Semi-Minor Axis cannot be negative. Please enter a non-negative value.");
                    }
                } while (semiMinorAxis <= 0);
            }

            public override double Area()
            {
                return Math.PI * semiMajorAxis * semiMinorAxis;
            }

            public override double Perimetr()
            {
                double a = semiMajorAxis;
                double b = semiMinorAxis;

                double h = Math.Pow((a - b) / (a + b), 2);
                double perimeter = Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));

                return perimeter;
            }
        }

        static void Main(string[] args)
        {
            int choose;

            while (true)
            {
                Console.WriteLine("\nCHOOSE ANY SHAPE\n1.Triangle\n2.Square\n3.Rectangle\n4.Diamond\n5.Parallelogram\n6.Trapezoid\n7.Circle\n8.Ellipse\n0.Exit");
                choose = int.Parse(Console.ReadLine());

                if (choose == 0)
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }
                switch (choose)
                {
                    case 1:
                        Triangle triangle = new Triangle();
                        triangle.inputSide();
                        Console.WriteLine("\nThe area of the triangle is: " + triangle.Area());
                        Console.WriteLine("\nThe perimetr of the triangle is: " + triangle.Perimetr());
                        triangle.DetermineTriangleType();
                        break;
                    case 2:
                        Square square = new Square();
                        square.inputSide();
                        Console.WriteLine("\nThe area of the square is: " + square.Area());
                        Console.WriteLine("\nThe perimetr of the square is: " + square.Perimetr());
                        break;
                    case 3:
                        Rectangle rectangle = new Rectangle();
                        rectangle.inputSide();
                        Console.WriteLine("\nThe area of the rectangle is: " + rectangle.Area());
                        Console.WriteLine("\nThe perimetr of the rectangle is: " + rectangle.Perimetr());
                        break;
                    case 4:
                        Diamond diamond = new Diamond();
                        diamond.inputSide();
                        Console.WriteLine("\nThe area of the diamond is: " + diamond.Area());
                        Console.WriteLine("\nThe perimetr of the diamond is: " + diamond.Perimetr());
                        break;
                    case 5:
                        Parallelogram parallelogram = new Parallelogram();
                        parallelogram.inputSide();
                        Console.WriteLine("\nThe area of the diamond is: " + parallelogram.Area());
                        Console.WriteLine("\nThe perimetr of the diamond is: " + parallelogram.Perimetr());
                        break;
                    case 6:
                        Trapezoid trapezoid = new Trapezoid();
                        trapezoid.inputSide();
                        Console.WriteLine("\nThe area of the trapezoid is: " + trapezoid.Area());
                        Console.WriteLine("\nThe perimetr of the trapezoid is: " + trapezoid.Perimetr());
                        break;
                    case 7:
                        Circle circle = new Circle();
                        circle.inputSide();
                        Console.WriteLine("\nThe area of the circle is: " + circle.Area());
                        Console.WriteLine("\nThe circumference of the circle is: " + circle.Perimetr());
                        break;
                    case 8:
                        Ellipse ellipse = new Ellipse();
                        ellipse.inputSide();
                        Console.WriteLine("\nThe area of the ellipse is: " + ellipse.Area());
                        Console.WriteLine("\nThe perimeter of the ellipse is not directly calculable.");
                        break;
                }
            }
        }

    }
}
