namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //1- Fixed Grades Array
            int[] grades = new int[5];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nStudent Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            //2- Dynamic To-Do List
            List<string> todoList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter task " + (i + 1) + ": ");
                string task = Console.ReadLine();
                todoList.Add(task);
            }

            Console.WriteLine("To-Do List:");
            int number = 1;
            foreach (string task in todoList)
            {
                Console.WriteLine(number + ". " + task);
                number++;
            }*/

            //3- Browsing History Stack
            Stack<string> history = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL " + (i + 1) + ": ");
                string url = Console.ReadLine();
                history.Push(url);
            }

            history.Pop();
            Console.WriteLine("Current page:" + history.Peek());
            








        }
    }
}
