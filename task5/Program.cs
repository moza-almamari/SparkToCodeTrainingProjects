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
            }

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

            //4- Customer Service Queue
            Queue<string> customers = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer " + (i + 1) + ": ");
                string name = Console.ReadLine();
                customers.Enqueue(name);
            }

            string servedCustomer = customers.Dequeue();
            Console.WriteLine("Customer served: " + servedCustomer);
            
            //5- Array Grade Range
            int[] grades = new int[5];
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(grades);
            foreach (int grade in grades)
            {
                sum += grade;
            }

            double average = (double)sum / grades.Length;
            Console.WriteLine("\nResults:");
            Console.WriteLine("Lowest Grade: " + grades[0]);
            Console.WriteLine("Highest Grade: " + grades[grades.Length - 1]);
            Console.WriteLine("Average Grade: " + average);
            */

            //6- Filtered Shopping List
            List<string> shoppingList = new List<string>();
            string item = "";
            while (item.ToLower() != "done")
            {
                Console.Write("Enter an item (or type 'done' to finish): ");
                item = Console.ReadLine();

                if (item.ToLower() != "done")
                {
                    shoppingList.Add(item);
                }
            }

            Console.WriteLine("Shopping List:");
            foreach (string shoppingItem in shoppingList)
            {
                Console.WriteLine("- " + shoppingItem);
            }

            Console.Write("Enter an item to remove: ");
            string removeItem = Console.ReadLine();
            shoppingList.Remove(removeItem);

            Console.WriteLine("Shopping List After Removal:");
            foreach (string shoppingItem in shoppingList)
            {
                Console.WriteLine("- " + shoppingItem);
            }







        }
    }
}
