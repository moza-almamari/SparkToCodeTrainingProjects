namespace session1_day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Taking User Input
            //Console.Write("Please Enter Your Name: ");
            //string userName = Console.ReadLine();

            //Console.Write("Please Enter Your Age: ");
            //int userAge = int.Parse(Console.ReadLine());

            //Console.Write("Please Enter Your Salary: ");
            //float userSalary = float.Parse(Console.ReadLine());

            //Console.WriteLine($"Hello " + userName);

            ///////////////////////////////////////////////////////////////////
            ///*
            // * 
            // * long comment 
            // * 
            // */
            /////////////////////////////////////////////////////////////////////
            ////Arithmetic Operators + Logical Operators
            //Console.WriteLine("enter first number: ");
            //float firstNumber = float.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number: ");
            //float secondNumber = float.Parse(Console.ReadLine());

            //float add = firstNumber + secondNumber;
            //float subtract = firstNumber - secondNumber;
            //float mult = firstNumber * secondNumber;
            //float div = firstNumber / secondNumber;
            //float reminder = firstNumber % secondNumber;
            //bool comparison = firstNumber == secondNumber;
            //bool testResult = !(10 > 5);

            //// and:  &&
            //// Or:   ||
            //// not:  !

            //Console.WriteLine("Addition result: " + add);
            //Console.WriteLine("Subtraction result: " + subtract);
            //Console.WriteLine("multiplication result: " + mult);
            //Console.WriteLine("Division result: " + div);
            //Console.WriteLine("Reminder result: " + reminder);
            //Console.WriteLine("Comparison result: " + comparison);
            //Console.WriteLine(testResult);

            //////////////////////////////////////////////////////////////////////////////
            ///
            //if else statement 

            //Console.Write("Enter your degree: ");
            //float degree = float.Parse(Console.ReadLine());
            //if (degree < 50)
            //{
            //    Console.WriteLine("you failed");
            //}
            //else
            //{
            //    Console.WriteLine("you passed");
            //}

                ///////////////////////////////////////
            Console.Write("Enter your degree: ");
            float degree = float.Parse(Console.ReadLine());

            if (degree >= 0 && degree < 50)
            {
                Console.WriteLine("you failed");
            }
            else if (degree >= 50 && degree < 60)
            {
                Console.WriteLine("you passed with Grade: D");
            }
            else if (degree >= 60 && degree < 70)
            {
                Console.WriteLine("you passed with Grade: C");
            }
            else if (degree >= 70 && degree < 80)
            {
                Console.WriteLine("you passed with Grade: B");
            }
            else if (degree > 80)
            {

                Console.WriteLine("you passed with Grade: A");
            }
            else
            {
                Console.WriteLine("you entered a wrong number");
            }



        }
    }
}
