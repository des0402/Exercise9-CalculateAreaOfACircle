using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_CalculateAreaOfACircle
{
    class Program
    {
        //Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.
        //Perimeter = 2πr
        //Area = πr2( r square)
        static void Main(string[] args)
        {
            Console.WriteLine("***Calculate Perimeter and Area of a circle\n");
            chooseOption(); 
        }

        private static void chooseOption()
        {
            Console.WriteLine("select your option 1 or 2");
            Console.WriteLine("1) Calculate Perimeter");
            Console.WriteLine("2) Calculate Area");
            Console.WriteLine("3) Exit");
            Console.Write("\nEnter your option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter radius: ");
                    double radius1 = double.Parse(Console.ReadLine());
                    calculatePerimeter(radius1);
                    break;
                case 2:
                    Console.Write("Enter radius: ");
                    double radius2 = double.Parse(Console.ReadLine());
                    calculateArea(radius2);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("You have select wrong option! try again");
                    break;
            }
        }

        private static void calculatePerimeter(double r)
        {
            double perimeter = 2 *Math.PI* r; 
            Console.WriteLine("Perimeter of Circle is: {0:0.00}\n", perimeter);
            Console.ReadLine();
        }

        private static void calculateArea(double r)
        {
            double area = Math.PI *r*r;
            Console.WriteLine("Area of Circle is: {0:0.00}", area);
            Console.ReadLine();
        }
    }
}
