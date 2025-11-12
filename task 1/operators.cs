//This is the task 1 of workshop 3
namespace Task_1
{
    internal class Operators
    {
        // Add two numbers
        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        // Subtract two numbers
        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference: {a - b}");
        }

        // Multiply two numbers
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Product: {a * b}");
        }

        // Divide two numbers
        public void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"Quotient: {a / b}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }

        // Find if number is odd or even
        public void FindOddEven(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
    }
}