using System;

namespace Simple_Menu_Driven_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nSimple Calculator Menu");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (GetNumbers(out double addNum1, out double addNum2))
                        {
                            double sum = addNum1 + addNum2;
                            Console.WriteLine("Result: " + sum);
                        }
                        break;

                    case "2":
                        if (GetNumbers(out double subNum1, out double subNum2))
                        {
                            double difference = subNum1 - subNum2;
                            Console.WriteLine("Result: " + difference);
                        }
                        break;

                    case "3":
                        Console.WriteLine("Exiting program...");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                        break;
                }
            }
        }

        // Method to safely get two numbers
        static bool GetNumbers(out double num1, out double num2)
        {
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input!");
                num2 = 0;
                return false;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input!");
                return false;
            }

            return true;
        }
    }
}