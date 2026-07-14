namespace task7
{
    public class Room
    {
        public int roomNumber { get; set; }
        public string roomType { get; set; }
        public double pricePerNight { get; set; }
        public bool isAvailable { get; set; }

        public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.pricePerNight = pricePerNight;
            this.isAvailable = isAvailable;
        }
        public void displayRoom()
        {
            Console.WriteLine($"Room Number: {roomNumber}");
            Console.WriteLine($"Room Type: {roomType}");
            Console.WriteLine($"Price Per Night: {pricePerNight}");
            Console.WriteLine($"Is Available: {isAvailable}");
        }
    }

    public class Guest
    {
        public int gustId { get; set; }
        public string gustName { get; set; }
        public int roomNumber { get; set; }
        public bool checkInDate { get; set; }
        public int totalNights { get; set; }

        public Guest(int gustId, string gustName, int roomNumber, bool checkInDate, int totalNights)
        {
            this.gustId = gustId;
            this.gustName = gustName;
            this.roomNumber = roomNumber;
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
        }
        public void displayGuest()
        {
            Console.WriteLine($"Guest ID: {gustId}");
            Console.WriteLine($"Guest Name: {gustName}");
            Console.WriteLine($"Room Number: {roomNumber}");
            Console.WriteLine($"Check In Date: {checkInDate}");
            Console.WriteLine($"Total Nights: {totalNights}");
        }
        public void calculateTotalCost(double pricePerNight)
        {
            double totalCost = pricePerNight * totalNights;
            Console.WriteLine($"Total Cost: {totalCost}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n================================================");
                Console.WriteLine("\nGRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("\n================================================");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("================================================");
                Console.Write("Enter your choice: ");

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
                    //case 1: 
                    //case 2:
                    //case 3: 
                    //case 4: 
                    //case 5: 
                    //case 6: 
                    //case 7: 
                    //case 8: 
                    //case 9: 
                    //case 10: 
                    //case 11: 
                    //case 12: 
                    //case 13: 
                    //case 14: 
                    case 15:

                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 15.");
                        break;
                }
            }
        }
    }
}
