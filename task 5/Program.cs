//This is task 5 of workshop 3
namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum from 1 to {N} is: {sum}");
            Console.WriteLine();

            Console.WriteLine("Printing numbers from 1 to 20 (skip multiples of 4, stop at 15):");
            int num = 1;

            while (num <= 20)
            {
                if (num == 15)
                    break;

                if (num % 4 == 0)
                {
                    num++;
                    continue;
                }

                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine();

            int[] numbers = { 2, 4, 6, 8, 10 };
            int arraySum = 0;

            foreach (int item in numbers)
            {
                arraySum += item;
            }

            Console.WriteLine("Sum of all elements in array: " + arraySum);
        }
    }
}
