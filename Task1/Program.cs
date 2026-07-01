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

            //if (number % 2 == 0 )
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}

            ////////////////////////////////////////////////////////////////

            //4- Voting Eligibility
            Console.Write("Please Enter a age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.Write("Do you hold valid national ID (yes/no)? ");
            bool hasNationalID = Console.ReadLine().Trim().ToLower() == "yes";

            if (userAge >= 18 && hasNationalID)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            


        }
    }
}
