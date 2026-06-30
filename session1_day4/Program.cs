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

            /////////////////////////////////////////////////////////////////
            /*
             * 
             * long comment 
             * 
             */
            ///////////////////////////////////////////////////////////////////
            //Arithmetic Operators + Logical Operators
            Console.WriteLine("enter first number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            float add = firstNumber + secondNumber;
            float subtract = firstNumber - secondNumber;
            float mult = firstNumber * secondNumber;
            float div = firstNumber / secondNumber;
            float reminder = firstNumber % secondNumber;
            bool comparison = firstNumber == secondNumber;
            bool testResult = !(10 > 5);

            Console.WriteLine("Addition result: " + add);
            Console.WriteLine("Subtraction result: " + subtract);
            Console.WriteLine("multiplication result: " + mult);
            Console.WriteLine("Division result: " + div);
            Console.WriteLine("Reminder result: " + reminder);
            Console.WriteLine("Comparison result: " + comparison);
            Console.WriteLine(testResult);

        }
    }
}
