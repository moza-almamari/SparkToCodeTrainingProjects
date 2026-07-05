namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //1- Absolute Difference
            Console.Write("Enter the first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int diff = Math.Abs(numberOne - numberTwo);
            Console.WriteLine("Difference = " + diff);

            //2- Power & Root Explorer
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            double square = Math.Pow(number, 2);
            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("Square = " + square);
            Console.WriteLine("Square Root = " + squareRoot);

            //3-  Name Formatter
            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Uppercase = " + name.ToUpper());
            Console.WriteLine("Lowercase = " + name.ToLower());
            Console.WriteLine("Number of characters = " + name.Length);
            
            //4- Subscription End Date
            Console.Write("Enter the number of trial days: ");
            int days = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime endDate = today.AddDays(days);

            Console.WriteLine("Trial End Date = " + endDate.ToString("yyyy-MM-dd"));
            
            //5- Grade Rounding System
            Console.Write("Enter your exam score: ");
            double score = double.Parse(Console.ReadLine());
            double roundedScore = Math.Round(score);
            Console.WriteLine("Rounded Score = " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Result = Pass");
            }
            else
            {
                Console.WriteLine("Result = Fail");
            }
            //6- Password Strength Checker
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            if (password.Length >= 8 && !password.ToLower().Contains("password"))
            {
                Console.WriteLine("Strong");
            }
            else
            {
                Console.WriteLine("Weak");

                if (password.Length < 8)
                {
                    Console.WriteLine("Reason: Less than 8 characters.");
                }

                if (password.ToLower().Contains("password"))
                {
                    Console.WriteLine("Reason: Contains the word 'password'.");
                }
            }*/
            //7- Clean Name Comparator
            Console.Write("Enter the first name: ");
            string name1 = Console.ReadLine().Trim().ToUpper();

            Console.Write("Enter the second name: ");
            string name2 = Console.ReadLine().Trim().ToUpper();

            if (name1 == name2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
        }
    }
    }
