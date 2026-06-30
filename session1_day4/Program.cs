namespace session1_day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taking User Input
            Console.Write("Please Enter Your Name: ");
            string userName = Console.ReadLine();        

            Console.Write("Please Enter Your Age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Your Salary: ");
            float userSalary = float.Parse(Console.ReadLine());

            Console.WriteLine($"Hello " + userName);

        }
    }
}
