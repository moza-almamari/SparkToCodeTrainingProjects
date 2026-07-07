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

            Console.WriteLine("Area = " + area + " Perimeter = " + perimeter); */

            //7- Prompt for the task 7
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());
            string grade = GetGradeLetter(score);
            Console.WriteLine("Grade = " + grade);
        }
    }
}
