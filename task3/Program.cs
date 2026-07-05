namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Absolute Difference
            Console.Write("Enter the first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int diff = Math.Abs(numberOne - numberTwo);
            Console.WriteLine("Difference = " + diff);
        }
    }
}
