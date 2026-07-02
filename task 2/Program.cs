
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
            
            //3- Multiplication Table
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
            
            //4- Password Retry
            string correctPassword = "Spark2026";
            string inputPassword  = "" ;

            while(inputPassword != correctPassword)
            {
                Console.Write("Enter the password: ");
                inputPassword = Console.ReadLine();
                if (inputPassword == correctPassword)
                {
                    Console.WriteLine("Access granted.");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            //5- Number Guessing Game
            int secret = 42;
            int guess;
            int attempts = 0;

            do
            {
                Console.Write("Guess the number: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess > secret)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct!");
                }

            } while (guess != secret);

            Console.WriteLine("Attempts: " + attempts);
            
            //6- Safe Division Calculator
            try
            {
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid numbers.");
            }

            //7- Repeating Menu with Exit Option
            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Greeting");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;

                        case 2:
                            Console.WriteLine("Good Morning!");
                            break;

                        case 3:
                            Console.WriteLine("Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number.");
                }

                Console.WriteLine();
            }
            //8- Sum of Even Numbers Only
            Console.Write("Enter a positive number: ");
            int n = int.Parse(Console.ReadLine());

            int sumnum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumnum = sumnum + i;
                }
            }
            Console.WriteLine("Sum = " + sumnum);



        }
    }
    
}
