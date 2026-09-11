using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Simple Calculator =====");

        bool continueCalculating = true;

        while (continueCalculating)
        {
            // Get first number
            double firstNumber = ReadNumber("Enter first number: ");

            // Get operator
            char operation = ReadOperator();

            // Get second number
            double secondNumber = ReadNumber("Enter second number: ");

            // Prevent division by zero
            while (operation == '/' && secondNumber == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                secondNumber = ReadNumber("Enter another number: ");
            }

            // Calculate result
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;

                case '-':
                    result = firstNumber - secondNumber;
                    break;

                case '*':
                    result = firstNumber * secondNumber;
                    break;

                case '/':
                    result = firstNumber / secondNumber;
                    break;
            }

            Console.WriteLine($"Result: {result}");

            // Ask user to continue
            continueCalculating = AskToContinue();

            if (continueCalculating)
            {
                Console.Clear();
                Console.WriteLine("===== Simple Calculator =====");
            }
        }

        Console.WriteLine("Thank you for using the calculator!");
    }


    // Read and validate number
    static double ReadNumber(string message)
    {
        double number;

        while (true)
        {
            Console.Write(message);

            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }


    // Read and validate operator
    static char ReadOperator()
    {
        while (true)
        {
            Console.Write("Enter operator (+, -, *, /): ");

            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input) &&
                input.Length == 1 &&
                (input[0] == '+' ||
                 input[0] == '-' ||
                 input[0] == '*' ||
                 input[0] == '/'))
            {
                return input[0];
            }

            Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
        }
    }


    // Ask user if they want to continue
    static bool AskToContinue()
    {
        while (true)
        {
            Console.Write("Do you want to calculate again? (Y/N): ");

            string input = Console.ReadLine();

            if (string.Equals(input, "Y", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (string.Equals(input, "N", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            Console.WriteLine("Invalid input. Please enter Y or N.");
        }
    }
}