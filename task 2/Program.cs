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
        }
}
}
