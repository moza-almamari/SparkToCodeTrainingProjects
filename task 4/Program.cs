namespace task_4
{
    internal class Program
    {
        //1- Personalized Welcome Function
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }
        //2- Square Number Function
        static int Square(int number)
        {
            return number * number;
        }
        static void Main()
        {
            /*
            // Prompt for the task 1  
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);
            */
            // Prompt for the task 2
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("Square = " + result);
        }
    }
}
