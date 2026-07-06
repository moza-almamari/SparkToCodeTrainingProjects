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
            }
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
            //8- Membership Expiry Checker
            try
            {
                Console.Write("Enter membership start date (yyyy-MM-dd): ");
                DateTime startDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter number of membership days: ");
                int days = int.Parse(Console.ReadLine());

                DateTime expiryDate = startDate.AddDays(days);

                Console.WriteLine("Expiry Date = " + expiryDate.ToString("yyyy-MM-dd"));

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Membership is Active");
                }
                else
                {
                    Console.WriteLine("Membership is Expired");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
            //9- Round Up / Round Down Explorer
            Console.Write("Enter a decimal number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double nearest = Math.Round(num);
            double roundUp = Math.Ceiling(num);
            double roundDown = Math.Floor(num);

            Console.WriteLine("Nearest whole number: " + nearest);
            Console.WriteLine("Always rounded up: " + roundUp);
            Console.WriteLine("Always rounded down: " + roundDown);
            
            //10- Word Position Finder
            Console.Write("Enter a full sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter a word to search for: ");
            string word = Console.ReadLine();
            int firstIndex = sentence.IndexOf(word);
            int lastIndex = sentence.LastIndexOf(word);

            if (firstIndex == -1)
            {
                Console.WriteLine("Word not found in the sentence.");
            }
            else
            {
                Console.WriteLine("\nResults:");
                Console.WriteLine("First occurrence index: " + firstIndex);
                Console.WriteLine("Last occurrence index: " + lastIndex);

            }
            //11- One-Time Password (OTP) Generator
            Random random = new Random();
            int otp = random.Next(1000, 10000);
            Console.WriteLine("Your OTP is: " + otp);

            int attempts = 0;
            while (attempts < 3)
            {
                try
                {
                    Console.Write("Enter the OTP: ");
                    int code = int.Parse(Console.ReadLine());

                    if (code == otp)
                    {
                        Console.WriteLine("Verified");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect OTP");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                attempts++;
            }

            Console.WriteLine("Verification Failed");*/

            //12- Birthday Insights
            try
            {
                Console.Write("Enter your date of birth (yyyy-MM-dd): ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());

                int age = DateTime.Today.Year - birthDate.Year;

                if (DateTime.Today.Month < birthDate.Month ||
                   (DateTime.Today.Month == birthDate.Month && DateTime.Today.Day < birthDate.Day))
                {
                    age--;
                }

                Console.WriteLine("Age = " + age);
                Console.WriteLine("Day of Birth = " + birthDate.DayOfWeek);
            }
            catch
            {
                Console.WriteLine("Invalid date.");
            }

        }
    }
    }
