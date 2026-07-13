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
            Console.WriteLine("Account holder name: " + HolderName
                + "\nBalance: " + Balance);
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
        public int Grade { get; set; }
        private string email;
        private int age;


        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }
        private void SendEmail()
        {
            Console.WriteLine("Email registered successfully");
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
            else
            {
                Console.WriteLine("Not enough stock");
            }
            LogTransaction();
        }
        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }
        public double GetInventoryValue()
        {
            PrintDetails();
            return StockQuantity * Price;

        }
        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName
                + "\nPrice: " + Price
                + "\nStock Quantity: " + StockQuantity);
        }
        private void LogTransaction()
        {
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
                    case 1: ViewAccountDetails(account1, account1); break;
                    case 2: UpdateStudentAddress(student1, student2); break;
                    case 3: MakeDeposit(account1, account2); break;
                    case 4: MakeWithdrawal(account1, account2); break;
                    case 5: ViewProductDetails(product1, product2); break;
                    case 6: RegisterStudent(student1, student2); break;
                    case 7: CompareAccountBalances(account1, account2); break;
                    case 8: RestockProduct(product1, product2); break;
                    case 9: TransferBetweenAccounts(account1, account2); break;
                    case 10: UpdateStudentGrade(student1, student2); break;
                    case 11: StudentReportCard(student1, student2); break;
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
        //Case 1 - View Account Details
        static void ViewAccountDetails(BankAccount account1, BankAccount account2)
        {
            Console.Write("Choose account (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                account1.CheckBalance();
            }
            else if (choice == 2)
            {
                account2.CheckBalance();
            }
        }

        //Case 2 - Update Student Address
        static void UpdateStudentAddress(Student student1, Student student2)
        {
            Console.Write("Choose student (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new address: ");
            string newAddress = Console.ReadLine();
            if (choice == 1)
            {
                student1.Address = newAddress;
                Console.WriteLine($"Student {student1.Name}'s address updated to: {student1.Address}");
            }
            else if (choice == 2)
            {
                student2.Address = newAddress;
                Console.WriteLine($"Student {student2.Name}'s address updated to: {student2.Address}");
            }
        }

        //Case 3 - Make a Deposit
        static void MakeDeposit(BankAccount account1, BankAccount account2)
        {
            Console.Write("Choose account (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter deposit amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (choice == 1)
            {
                account1.Deposit(amount);
                Console.WriteLine($"Deposited {amount:C} to account {account1.AccountNumber}. New balance: {account1.Balance:C}");
            }
            else if (choice == 2)
            {
                account2.Deposit(amount);
                Console.WriteLine($"Deposited {amount:C} to account {account2.AccountNumber}. New balance: {account2.Balance:C}");
            }
        }
        //Case 4 - Make a Withdrawal
        static void MakeWithdrawal(BankAccount account1, BankAccount account2)
        {
            Console.Write("Choose account (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                account1.Withdraw(amount);
                Console.WriteLine("Balance:" + account1.Balance);
            }
            else if (choice == 2)
            {
                account2.Withdraw(amount);
                Console.WriteLine("Balance:" + account2.Balance);
            }
        }
        //Case 5 - View Product Details
        static void ViewProductDetails(Product product1, Product product2)
        {
            Console.Write("Choose product (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Inventory Value: " + product1.GetInventoryValue());
            }
            else if (choice == 2)
            {
                Console.WriteLine("Inventory Value: " + product2.GetInventoryValue());
            }
        }

        //Case 6 - Register a Student
        static void RegisterStudent(Student student1, Student student2)
        {
            Console.Write("Choose student (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            if (choice == 1)
            {
                student1.Register(email);

            }
            else if (choice == 2)
            {
                student2.Register(email);

            }
        }

        //Case 7 - Compare Two Account Balances
        static void CompareAccountBalances(BankAccount account1, BankAccount account2)
        {
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + "has more money.");
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine(account2.HolderName + "has more money");
            }
            else
            {
                Console.WriteLine("Both accounts have the same balance.");
            }
        }

        //Case 8 - Restock Product & Stock Level Check
        static void RestockProduct(Product product1, Product product2)
        {
            Console.Write("Choose product (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity to add: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Product chossenProduct;

            if (choice == 1)
            {
                chossenProduct = product1;
            }
            else if (choice == 2)
            {
                chossenProduct = product2;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            chossenProduct.Restock(quantity);

            if (chossenProduct.StockQuantity < 10)
            {
                Console.WriteLine("Stock Level: Low");
            }
            else if (chossenProduct.StockQuantity < 50)
            {
                Console.WriteLine("Stock Level: Moderate");
            }
            else
            {
                Console.WriteLine("Stock Level: Well Stocked");
            }
        }

        //Case 9 - Transfer Between Accounts
        static void TransferBetweenAccounts (BankAccount account1, BankAccount account2)
        {
            Console.Write("Choose source account (1 or 2): ");
            int sourceChoice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose destination account (1 or 2): ");
            int destinationChoice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter transfer amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            BankAccount sourceAccount;
            BankAccount destinationAccount;

            if (sourceChoice == 1)
            {
                sourceAccount = account1;
            }
            else if (sourceChoice == 2)
            {
                sourceAccount = account2;
            }
            else
            {
                Console.WriteLine("Invalid source account");
                return;
            }

            if (destinationChoice == 1)
            {
                destinationAccount = account1;
            }
            else if (destinationChoice == 2)
            {
                destinationAccount = account2;
            }
            else
            {
                Console.WriteLine("Invalid destination account");
                return;
            }

            if (sourceAccount == destinationAccount)
            {
                Console.WriteLine("Source and destination accounts cannot be the same");
                return;
            }

            if (sourceAccount.Balance >= amount)
            {
                sourceAccount.Withdraw(amount);
                destinationAccount.Deposit(amount);

                Console.WriteLine("Transfer completed successfully");
            }
            else
            {
                Console.WriteLine("Transfer failed, Insufficient balance");
            }
        }

        //Case 10 - Update Student Grade (Validated)
        static void UpdateStudentGrade(Student student1, Student student2)
        {
            Console.Write("Choose student (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Student selectedStudent;

            if (choice == 1)
            {
                selectedStudent = student1;
            }
            else if (choice == 2)
            {
                selectedStudent = student2;
            }
            else
            {
                Console.WriteLine("Invalid student choice");
                return;
            }

            Console.Write("Enter the new grade (0-100): ");
            int input = int.Parse(Console.ReadLine());

            

            if (input < 0 || input > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100");
                return;
            }

            selectedStudent.Grade = input;

            Console.WriteLine("Grade updated successfully");
            Console.WriteLine($"New Grade: {selectedStudent.Grade}");
        }
        //Case 11 - Student Report Card
        static void StudentReportCard(Student student1, Student student2)
        {
            Console.Write("Choose student (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Student selectedStudent;

            if (choice == 1)
            {
                selectedStudent = student1;
            }
            else if (choice == 2)
            {
                selectedStudent = student2;
            }
            else
            {
                Console.WriteLine("Invalid student choice");
                return;
            }

            Console.WriteLine("\nStudent Report Card");
            Console.WriteLine("Name: "+ selectedStudent.Name);
            Console.WriteLine("Address: "+selectedStudent.Address);
            Console.WriteLine($"Grade: "+selectedStudent.Grade);

            if (selectedStudent.Grade >= 60)
            {
                Console.WriteLine("Status  : Pass");
            }
            else
            {
                Console.WriteLine("Status  : Fail");
            }
        }




    }
}

