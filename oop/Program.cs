namespace oop
{
    class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
     

    internal class Program
    {
        static void Main(string[] args)
        {
            int grade1 = 60;
            string name1 = "John";
            string address1 = "123 Main St";


            Student student1 = new Student(); // create obj
        }
    }
}
