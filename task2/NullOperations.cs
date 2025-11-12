//This is the task2 of workshop 3
namespace Task_2
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {

            string username = null;

            string ternaryResult = (username == null) ? "Username is not available" : username;
            Console.WriteLine("Ternary Operator: " + ternaryResult);

            string coalescingResult = username ?? "Username is not available";
            Console.WriteLine("Null-Coalescing Operator: " + coalescingResult);

            username ??= "Mukunda";
            Console.WriteLine("After Null-Coalescing Assignment: " + username);
        }
    }
}