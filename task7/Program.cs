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
            
        }
    }
}
