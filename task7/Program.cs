using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public string guestId { get; set; }
        public string guestName { get; set; }
        public string roomNumber { get; set; }
        public string checkInDate { get; set; }
        public int totalNights { get; set; }

        public Guest(string guestId, string guestName, string roomNumber, string checkInDate, int totalNights)
        {
            this.guestId = guestId;
            this.guestName = guestName;
            this.roomNumber = roomNumber;
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
        }
        public void displayGuest()
        {
            Console.WriteLine($"Guest ID: {guestId}");
            Console.WriteLine($"Guest Name: {guestName}");
            Console.WriteLine($"Room Number: {roomNumber}");
            Console.WriteLine($"Check In Date: {checkInDate}");
            Console.WriteLine($"Total Nights: {totalNights}");
        }
        public double calculateTotalCost(double pricePerNight)
        {
            double totalCost = pricePerNight * totalNights;
            return totalCost;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room(101, "Single", 100.0, true));
            rooms.Add(new Room(102, "Double", 200.0, true));
            rooms.Add(new Room(103, "Suite", 400.0, true));
            rooms.Add(new Room(104, "Single", 100.0, true));
            rooms.Add(new Room(105, "Double", 200.0, true));
            rooms.Add(new Room(106, "Suite", 400.0, true));

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
                    case 1: addNewRoom(rooms); break;
                    case 2: registerNewGuest(guests); break;
                    case 3: bookRoom(rooms, guests); break;
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

        //Case 01 Add New Room
        public static void addNewRoom(List<Room> rooms)
        {
            Console.Write("Enter Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            if (roomNumber <= 0)
            {
                Console.WriteLine("Invalid room number");
                return;
            }

            bool roomExists = rooms.Any(r => r.roomNumber == roomNumber);
            if (roomExists)
            {
                Console.WriteLine("Room already exists.");
                return;
            }

            Console.Write("Enter Room Type (Single/Double/Suite): ");
            string roomType = Console.ReadLine();
            Console.Write("Enter Price Per Night: ");
            double pricePerNight = double.Parse(Console.ReadLine());
            if (pricePerNight <= 0)
            {
                Console.WriteLine("Invalid price");
                return;
            }


            Room newRoom = new Room(roomNumber, roomType, pricePerNight, true);
            rooms.Add(newRoom);
            Console.WriteLine("\nNew room added successfully!");
        }

        //Case 02 Register New Guest
        public static void registerNewGuest(List<Guest> guests)
        {

            Console.Write("Enter Guest Name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter Check-In Date (yyyy-mm-dd): ");
            string checkInDate = Console.ReadLine();

            Console.Write("Enter Total Nights: ");
            int totalNights = int.Parse(Console.ReadLine());
            if (totalNights <= 0)
            {
                Console.WriteLine("Invalid number of nights");
                return;
            }
            string guestId = "G" + (guests.Count + 1).ToString("D3");

            Guest newGuest = new Guest(guestId, guestName, "Not Assigned", checkInDate, totalNights);
            guests.Add(newGuest);
            Console.WriteLine("\nNew guest registered successfully!");
            Console.WriteLine($"Guest ID: {guestId}");
            Console.WriteLine($"Name: {guestName}");
            Console.WriteLine($"Check-in Date: {checkInDate}");
            Console.WriteLine($"Total Nights: {totalNights}");
            Console.WriteLine($"Room: Not Assigned");

        }

        //Case 03 Book a Room for a Guest
        static void bookRoom(List<Room> rooms, List<Guest> guests)
        {
            Console.Write("Enter Guest ID: ");
            string guestId = Console.ReadLine();
            Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);
            if (guest == null)
            {
                Console.WriteLine("Guest not found");
                return;
            }

            Console.Write("Enter Room Number: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());
            Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine("Room not found");
                return;
            }

            if (!room.isAvailable)
            {
                Console.WriteLine("Room is already booked");
                return;
            }
            guest.roomNumber = room.roomNumber.ToString();
            room.isAvailable = false;
            Console.WriteLine("\nBooking Confirmation");
            Console.WriteLine($"Guest Name: {guest.guestName}");
            Console.WriteLine($"Room Number: {room.roomNumber}");
            Console.WriteLine($"Room Type: {room.roomType}");
            Console.WriteLine($"Price Per Night: {room.pricePerNight}");
            Console.WriteLine($"Total Nights: {guest.totalNights}");
            Console.WriteLine($"Total Cost: {guest.calculateTotalCost(room.pricePerNight)}");

        }
    }
}

