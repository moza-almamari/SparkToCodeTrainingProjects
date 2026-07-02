namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //1- Countdown Timer
            Console.Write("Enter a starting number for the countdown: ");
            int countdownStart = int.Parse(Console.ReadLine());

            for (int i = countdownStart ; i > 0 ; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");
            
            //2- Sum of Numbers 1 to N
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {N} is: {sum}");
        }
}
}
