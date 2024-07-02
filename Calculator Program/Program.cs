using System;

class Program
{
    static void addition()
    {
        double num1, num2;
        Console.WriteLine("First Number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Second Number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }

    static void subtraction()
    {
        double num1, num2;
        Console.WriteLine("First Number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Second Number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    }

    static void multiplication()
    {
        double num1, num2;
        Console.WriteLine("First Number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Second Number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
    }

    static void division()
    {
        double num1, num2;
        Console.WriteLine("First Number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Second Number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Divide by Zero Error");
        }
        else
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
    }

    static void power()
    {
        double num1, num2;
        Console.WriteLine("Base: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Exponent: ");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
    }

    static void sqrt()
    {
        double num1, num1Pos;
        Console.WriteLine("Enter your number:");
        num1 = Convert.ToDouble(Console.ReadLine());
        if (num1 < 0)
        {
            num1Pos = Math.Abs(num1);
            Console.WriteLine($"√{num1} = {Math.Sqrt(num1Pos)}i");
        }
        else
        {
            Console.WriteLine($"√{num1} = {Math.Sqrt(num1)}");
        }
    } 

    static void calculation()
    {
        while (true)
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplication");
            Console.WriteLine("[4] Division");
            Console.WriteLine("[5] Exponential");
            Console.WriteLine("[6] Square Root");
            Console.WriteLine("[0] Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 0)
            {
                Console.WriteLine("-EXITING PROGRAM-");
                break;
            }

            switch (choice)
            {
                case 1:
                    addition();
                    break;
                case 2:
                    subtraction();
                    break;
                case 3:
                    multiplication();
                    break;
                case 4:
                    division();
                    break;
                case 5:
                    power();
                    break;
                case 6:
                    sqrt();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid number");
                    continue;
            }
            Console.WriteLine();
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
        }
    }

    static void Main(String[] args) { calculation(); }
}
