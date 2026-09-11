namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator ===");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                result = num1 / num2;
                break;

            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}