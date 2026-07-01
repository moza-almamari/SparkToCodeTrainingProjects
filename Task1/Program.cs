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

            ////////////////////////////////////////////////////////////////

            //3- Even or Odd Checker
            Console.Write("Please Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 )
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
    }
}
}
