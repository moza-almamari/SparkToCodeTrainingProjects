namespace oop_s2
{
    public class BankAccount
    {
        public int AccountId { get; }
        public string holderName;
        public double balance;
        public BankAccount(int Id, double amount)
        {
            AccountId = Id;
            balance = amount;
        }
        public void checkBalance()
        {
            Console.WriteLine(balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
