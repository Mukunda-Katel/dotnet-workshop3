namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age below");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);

            if (age < 13)
            { 
                    Console.WriteLine("Child");
            }

            if (age >=13 & age <=19)
            {
                Console.WriteLine("Teenager");
            }

            if (age >= 20)
            {
                Console.WriteLine("Adult");

            }


        }
    }
}
