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
            List<BankAccount> accounts = new List<BankAccount>();
            BankAccount b1 = new BankAccount(1, 100);
            accounts.Add(b1);
            BankAccount b2 = new BankAccount(2, 205);
            accounts.Add(b2);
            accounts.Add(new BankAccount(3, 210));
            accounts.Add(new BankAccount(4, 113));

            Console.Write("enter your name: ");
            string userName = Console.ReadLine();
            accounts[0].holderName = userName;
            accounts[1].holderName = "Ali";
            accounts[2].holderName = "Sara";
            accounts[3].holderName = "Omar";

            List<BankAccount> selectedAccounts = accounts.Where(b => b.balance > 150).ToList();
            if (selectedAccounts.Count > 0)
            {
                foreach (BankAccount account in selectedAccounts) { Console.WriteLine(account.holderName); }
            }
        }
    }
}
