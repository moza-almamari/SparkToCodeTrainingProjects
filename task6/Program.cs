namespace task6
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int AccountNumber, string HolderName, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.HolderName = HolderName;
            this.Balance = Balance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            SendEmail();

        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
                SendEmail();
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            
        }
        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }
        private void PrintInformation()
        {
            Console.WriteLine("Account holder name: "+ HolderName
                + "\nBalance: "+ Balance);
        }
        private void SendEmail()
        {
            Console.WriteLine("Emil send");
        }

    }
    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Grade { get;  set; }
        private string email;
        private int age;

       
        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }
        private void SendEmail()
        {
            Console.WriteLine("Emil send");
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else {
                Console.WriteLine("Not enough stock");
            }
            LogTransaction();
        }
        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }
        public double GetlnventoryValue() {
            PrintDetails();
            return StockQuantity * Price;

        }
        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName
                + "\nPrice: " + Price
                + "\nStock Quantity: " + StockQuantity);
        }
        private void LogTransaction() {
            Console.WriteLine("Transaction logged");
        }

    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(1163, "Karim", 120);
            BankAccount account2 = new BankAccount(15203, "Ali", 63);

            Student student1 = new Student();
            student1.Name = "Ali";
            student1.Address = "Muscat";
            student1.Grade = 65;
            Student student2 = new Student();
            student2.Name = "Ahmed";
            student2.Address = "Muscat";
            student2.Grade = 70;

            Product product1 = new Product();
            product1.ProductName = "Wireless Mouse";
            product1.Price = 5.500;
            product1.StockQuantity = 50;

            Product product2 = new Product();
            product2.ProductName = "Mechanical Keyboard";
            product2.Price = 15.750;
            product2.StockQuantity = 20;

            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    //case 1: ViewAccountDetails(); break;
                    //case 2: UpdateStudentAddress(); break;
                    //case 3: MakeDeposit(); break;
                    //case 4: MakeWithdrawal(); break;
                    //case 5: ViewProductDetails(); break;
                    //case 6: RegisterStudent(); break;
                    //case 7: CompareAccountBalances(); break;
                    //case 8: RestockProduct(); break;
                    //case 9: TransferBetweenAccounts(); break;
                    //case 10: UpdateStudentGrade(); break;
                    //case 11: StudentReportCard(); break;
                    //case 12: AccountHealthStatus(); break;
                    //case 13: BulkSaleWithRevenue(); break;
                    //case 14: ScholarshipEligibilityCheck(); break;
                    //case 15: FullBalanceTopUpFlow(); break;
                    //case 16: QuickAccountOpening(); break;
                    //case 17: TotalStudentsCounter(); break;
                    //case 18: OverdrawnAccountCheck(); break;
                    //case 19: SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
            }
        }
    }
}

