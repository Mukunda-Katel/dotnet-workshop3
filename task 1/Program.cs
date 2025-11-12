namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            var ops = new Operators();

            int a = 12;
            int b = 4;

            ops.Add(a, b);
            ops.Subtract(a, b);
            ops.Multiply(a, b);
            ops.Divide(a, b);
            ops.FindOddEven(a);

        }
    }
}