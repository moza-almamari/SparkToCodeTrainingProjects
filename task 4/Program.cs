namespace task_4
{
    internal class Program
    {
        //1- Personalized Welcome Function
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }

        static void Main()
        {
            // Prompt for the task 1  
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);
        }
    }
}
