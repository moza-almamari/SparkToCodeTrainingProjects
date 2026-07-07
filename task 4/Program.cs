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
        //3- Celsius to Fahrenheit Function
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        //4- Fixed Menu Display Function
        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
        //5- Even or Odd Function
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        //6- Rectangle Area & Perimeter Functions
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }
        //7- Grade Letter Function
        static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        //8- Countdown Function
        static void Countdown(int number)
        {
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        //9- Overloaded Multiply Function
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        //10- Overloaded Area Calculator
        static double CalculateArea(double side)
        {
            return side * side;
        }

        static double CalculateArea10(double length, double width)
        {
            return length * width;
        }
        static void Main()
        {
            /*
            // Prompt for the task 1  
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);
            
            // Prompt for the task 2
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = Square(number);

            Console.WriteLine("Square = " + result);
            
            //3- Prompt for the task 3
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine("Fahrenheit = " + fahrenheit);
            

            //4- Prompt for the task 4
            DisplayMenu(); 

            //5- Prompt for the task 5
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsEven(number))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            } 

            //6- Prompt for the task 6
            Console.Write("Enter the length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area = " + area + " Perimeter = " + perimeter); 

            //7- Prompt for the task 7
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());
            string grade = GetGradeLetter(score);
            Console.WriteLine("Grade = " + grade); 

            //8- Prompt for the task 8
            Console.Write("Enter a starting number: ");
            int number = int.Parse(Console.ReadLine());
            Countdown(number); 

            //9- Prompt for the task 9
            Console.WriteLine("Multiply(int, int) = " + Multiply(2, 3));
            Console.WriteLine("Multiply(double, double) = " + Multiply(2.5, 3.5));
            Console.WriteLine("Multiply(int, int, int) = " + Multiply(2, 3, 4)); */

            //10- Prompt for the task 10
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.Write("Choose a shape: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter the side: ");
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine("Area = " + CalculateArea(side));
            }
            else if (choice == 2)
            {
                Console.Write("Enter the length: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter the width: ");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Area = " + CalculateArea10(length, width));
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            }
    }
}
