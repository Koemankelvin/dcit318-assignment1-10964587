using System;

namespace dcit318_assignment1_10964587
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the application to run:");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("Enter the number of your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RunGradeCalculator();
                    break;
                case 2:
                    RunTicketPriceCalculator();
                    break;
                case 3:
                    RunTriangleTypeIdentifier();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please run the program again and select a valid option.");
                    break;
            }
        }

        static void RunGradeCalculator()
        {
            Console.Write("Enter a numerical grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            string letterGrade;

            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            Console.WriteLine($"The corresponding letter grade is: {letterGrade}");
        }

        static void RunTicketPriceCalculator()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
        }

        static void RunTriangleTypeIdentifier()
        {
            Console.Write("Enter side 1: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter side 2: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter side 3: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}
