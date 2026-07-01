namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1- Personal Info Card
            //string name = "Sara";
            //int age = 21;
            //double height = 1.65;
            //bool isStudent = true;
            //Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height +
            //    ", Student: " + isStudent);

            //////////////////////////////////////////////////////////////////

            ////2- Rectangle Calculator
            //Console.Write("Please enter the length of the rectangle: ");
            //double length = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the width of the rectangle: ");
            //double width = double.Parse(Console.ReadLine());

            //double recArea = length * width;
            //double recPerimeter = 2 * (length + width);

            //Console.WriteLine("Rectangle area: " + recArea
            //    + ", Rectangle perimeter: " + recPerimeter);

            //////////////////////////////////////////////////////////////////

            ////3- Even or Odd Checker
            //Console.Write("Please Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}

            //////////////////////////////////////////////////////////////////

            ////4- Voting Eligibility
            //Console.Write("Please Enter a age: ");
            //int userAge = int.Parse(Console.ReadLine());

            //Console.Write("Do you hold valid national ID (yes/no)? ");
            //bool hasNationalID = Console.ReadLine().Trim().ToLower() == "yes";

            //if (userAge >= 18 && hasNationalID)
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}

            //////////////////////////////////////////////////////////////////

            ////5- Grade Letter Lookup
            //Console.Write("Enter your degree(A, B, C, D, F): ");
            //string degree = Console.ReadLine();

            //if (degree == "A")
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else if (degree == "B")
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (degree == "C")
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (degree == "D")
            //{
            //    Console.WriteLine("Pass");
            //}
            //else if (degree == "F")
            //{
            //    Console.WriteLine("Fail");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid degree entered.");
            //}

            //////////////////////////////////////////////////////////////////

            ////6- Temperature Converter
            //Console.Write("Enter your degree: ");
            //double degree = double.Parse(Console.ReadLine());

            //double fahrenheit = (degree * 9 / 5) + 32;

            //if (degree < 10)
            //{
            //    string weather = "Cold";
            //    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit +
            //    ", The weather is " + weather);
            //}
            //else if (degree >= 10 && degree < 30)
            //{
            //    string weather = "Mild";
            //    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit +
            //    ", The weather is " + weather);
            //}
            //else
            //{
            //    string weather = "Hot";
            //    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit +
            //    ", The weather is " + weather);
            //}

            //////////////////////////////////////////////////////////////////

            //7- Movie Ticket Pricing 
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 12)
            {
                Console.WriteLine("Category: Child, Ticket Price: 2.000 OMR");
            }
            else if (age >= 13 && age <= 59)
            {
                Console.WriteLine("Category: Adult, Ticket Price: 5.000 OMR");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Category: Senior, Ticket Price: 3.000 OMR");
                
            }
    
        }
    }
}
