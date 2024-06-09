using System;

class Program
{
    static double addition(double a, double b)
    {
        return a + b;
    }

    static double subtraction(double a, double b)
    {
        return a - b;
    }

    static double multiplication(double a, double b)
    {
        return a * b;
    }

    static double division(double a, double b)
    {
        return a / b;
    }

    static double sqrt(double a)
    {
        return Math.Sqrt(a);
    } 

    static void calculation()
    {
        while (true)
        {
            double num1, num2;

            Console.WriteLine("Choose an opperation: ");
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplication");
            Console.WriteLine("[4] Division");
            Console.WriteLine("[5] Square Root");
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
                    Console.WriteLine("First Number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second Number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"{num1} + {num2} = {addition(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine("First Number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second Number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"{num1} - {num2} = {subtraction(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine("First Number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second Number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"{num1} * {num2} = {multiplication(num1, num2)}");
                    break;
                case 4:
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
                        Console.WriteLine($"{num1} / {num2} = {division(num1, num2)}");
                    }
                    break;
                case 5:
                    Console.WriteLine("Enter your number:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    if (num1 < 0)
                    {
                        double num1Pos = Math.Abs(num1);
                        Console.WriteLine($"√{num1} = {sqrt(num1Pos)}i");
                    }
                    else
                    {
                        Console.WriteLine($"√{num1} = {sqrt(num1)}");
                    }
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

    static void Main(String[] args)
    {
        calculation();
    }
}
