using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace HotelManagementSystem;
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
                    case 4: viewAllRooms(rooms); break;
                    case 5: viewAllGuests(guests); break;
                    case 6: searchAndFilterRooms(rooms); break;
                    case 7: GuestBookingStatistics(guests, rooms); break;
                    case 8: updateRoomPrice(rooms); break;
                    case 9: GuestLookupByName(guests); break;
                    case 10: GuestLookupbyName(rooms); break;
                    case 11: CheckOutGuest(guests, rooms); break;
                    case 12: removeUnavailableRooms(rooms, guests); break;
                    case 13: extendGuestStay(guests, rooms); break;
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

        //Case 04 View All Rooms
        public static void viewAllRooms(List<Room> rooms)
        {
            if (rooms.Count() == 0)
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            Console.WriteLine($"Total Rooms: {rooms.Count()}");

            var roomList = rooms.OrderBy(r => r.roomNumber)
                .Select(r => $"Room: {r.roomNumber}  Type: {r.roomType}  Price: {r.pricePerNight}  Status: {(r.isAvailable ? "Available" : "Booked")}");

            foreach (string room in roomList)
            {
                Console.WriteLine(room);
            }
        }

        //Case 05 View All Guests
        public static void viewAllGuests(List<Guest> guests)
        {
            if (guests.Count() == 0)
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            Console.WriteLine($"Total Guests: {guests.Count()}");
            var guestList = guests
                .OrderBy(g => g.guestName)
                .Select(g => $"ID: {g.guestId}  Name: {g.guestName}  Room: {g.roomNumber}  Check-In: {g.checkInDate}  Nights: {g.totalNights}");

            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }

        //Case 06 Search & Filter Rooms
        public static void searchAndFilterRooms(List<Room> rooms)
        {
            Console.WriteLine("\nSearch & Filter Rooms ");
            Console.WriteLine("1. Show All Available Rooms");
            Console.WriteLine("2. Filter By Room Type");
            Console.WriteLine("3. Filter By Maximum Price");
            Console.WriteLine("4. Room Price Statistics");
            Console.WriteLine("0. Back");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var availableRooms = rooms
                        .Where(r => r.isAvailable)
                        .OrderBy(r => r.pricePerNight);

                    Console.WriteLine($"Rooms Found: {availableRooms.Count()}");

                    if (!availableRooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria");
                        return;
                    }

                    foreach (var room in availableRooms)
                    {
                        Console.WriteLine($"Room {room.roomNumber}  {room.roomType}  {room.pricePerNight:F2}  Available");
                    }
                    break;

                case 2:

                    Console.Write("Enter Room Type: ");
                    string type = Console.ReadLine();

                    var typeRooms = rooms
                        .Where(r => r.roomType.Equals(type, StringComparison.OrdinalIgnoreCase))
                        .OrderBy(r => r.roomNumber);

                    Console.WriteLine($"Rooms Found: {typeRooms.Count()}");

                    if (!typeRooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria");
                        return;
                    }

                    foreach (var room in typeRooms)
                    {
                        Console.WriteLine($"Room {room.roomNumber}  {room.roomType}  {room.pricePerNight:F2}  {(room.isAvailable ? "Available" : "Booked")}");
                    }
                    break;

                case 3:

                    Console.Write("Enter Maximum Price: ");
                    double maxPrice = double.Parse(Console.ReadLine());

                    var cheapRooms = rooms
                        .Where(r => r.isAvailable && r.pricePerNight <= maxPrice)
                        .OrderBy(r => r.pricePerNight);

                    Console.WriteLine($"Rooms Found: {cheapRooms.Count()}");

                    if (!cheapRooms.Any())
                    {
                        Console.WriteLine("No rooms found for the selected criteria");
                        return;
                    }

                    foreach (var room in cheapRooms)
                    {
                        Console.WriteLine($"Room {room.roomNumber}  {room.roomType}  {room.pricePerNight:F2}");
                    }

                    break;

                case 4:

                    Console.WriteLine("\nRoom Statistics");

                    Console.WriteLine($"Total Rooms: {rooms.Count()}");
                    Console.WriteLine($"Available Rooms: {rooms.Count(r => r.isAvailable)}");
                    Console.WriteLine($"Average Price: {rooms.Average(r => r.pricePerNight):F2}");
                    Console.WriteLine($"Cheapest Price: {rooms.Min(r => r.pricePerNight):F2}");
                    Console.WriteLine($"Highest Price: {rooms.Max(r => r.pricePerNight):F2}");

                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        //Case 07 Guest & Booking Statistics
        public static void GuestBookingStatistics(List<Guest> guests, List<Room> rooms)
        {
            Console.WriteLine(" Guest & Booking Statistics ");
            Console.WriteLine($"Total Guests: {guests.Count()}");
            Console.WriteLine($"Guests With Booking: {guests.Count(g => g.roomNumber != "Not Assigned")}");

            Console.WriteLine($"Total Rooms: {rooms.Count()}");
            Console.WriteLine($"Booked Rooms: {rooms.Count(r => !r.isAvailable)}");
            if (!guests.Any(g => g.roomNumber != "Not Assigned"))
            {
                Console.WriteLine("No active bookings recorded.");
                return;
            }

            double averageNights = guests.Where(g => g.roomNumber != "Not Assigned")
                .Average(g => g.totalNights);
            Console.WriteLine($"Average Nights: {averageNights:F2}");
            Console.WriteLine();

            Console.WriteLine("Top 3 highest spending guests");
            var topGuests = guests
                .Where(g => g.roomNumber != "Not Assigned")
                .OrderByDescending(g =>
                    g.calculateTotalCost(
                        rooms.First(r => r.roomNumber.ToString() == g.roomNumber).pricePerNight))
                .Take(3);

            foreach (var guest in topGuests)
            {
                Room room = rooms.First(r => r.roomNumber.ToString() == guest.roomNumber);

                Console.WriteLine($"{guest.guestName}  Room {guest.roomNumber}  OMR {guest.calculateTotalCost(room.pricePerNight):F2}");
            }

            Console.WriteLine(" ");

            var summary = guests
                .Where(g => g.roomNumber != "Not Assigned")
                .Select(g =>
                {
                    Room room = rooms.First(r => r.roomNumber.ToString() == g.roomNumber);

                    return $"{g.guestName} — Room {g.roomNumber} — {g.totalNights} nights — OMR {g.calculateTotalCost(room.pricePerNight):F2}";
                });

            foreach (string line in summary)
            {
                Console.WriteLine(line);
            }
        }

        //Case 08 Update Room Price
        public static void updateRoomPrice(List<Room> rooms)
        {
            Console.Write("Enter Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine("Room not found");
                return;
            }

            double oldPrice = room.pricePerNight;
            Console.Write("Enter New Price: ");
            double newPrice = double.Parse(Console.ReadLine());
            if (newPrice <= 0)
            {
                Console.WriteLine("Invalid price");
                return;
            }

            room.pricePerNight = newPrice;
            Console.WriteLine("Room price updated successfully!");
            Console.WriteLine($"Old Price: {oldPrice:F2}");
            Console.WriteLine($"New Price: {room.pricePerNight:F2}");
        }

        //Case 09 Guest Lookup by Name
        public static void GuestLookupByName(List<Guest> guests)
        {
            Console.Write("Enter guest name or part of the name: ");
            string search = Console.ReadLine();
            var matchingGuests = guests
                .Where(g => g.guestName.Contains(search, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"\nMatches Found: {matchingGuests.Count()}");

            if (matchingGuests.Count() == 0)
            {
                Console.WriteLine("No guests matched that search");
                return;
            }

            foreach (var guest in matchingGuests)
            {
                Console.WriteLine($"ID: {guest.guestId}  Name: {guest.guestName}  Room: {guest.roomNumber}");
            }
        }

        //Case 10 Room Type Breakdown Report
        public static void GuestLookupbyName(List<Room> rooms)
        {
            string[] roomTypes = { "Single", "Double", "Suite" };
            Console.WriteLine("\nRoom Type Breakdown Report");

            foreach (string type in roomTypes)
            {
                int count = rooms.Count(r => r.roomType.Equals(type, StringComparison.OrdinalIgnoreCase));

                Console.WriteLine($"{type} Rooms: {count}");

                if (count == 0)
                {
                    Console.WriteLine("Average Price: N/A");
                }
                else
                {
                    double average = rooms
                        .Where(r => r.roomType.Equals(type, StringComparison.OrdinalIgnoreCase))
                        .Average(r => r.pricePerNight);

                    Console.WriteLine($"Average Price: {average:F2}");
                }
            }
            double overallAverage = rooms.Average(r => r.pricePerNight);

            Console.WriteLine($"Overall Average Price: {overallAverage:F2}");
        }

        //Case 11 Check Out a Guest
        public static void CheckOutGuest(List<Guest> guests, List<Room> rooms)
        {
            Console.Write("Enter Guest ID: ");
            string guestId = Console.ReadLine();
            Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);

            if (guest == null)
            {
                Console.WriteLine("Guest not found");
                return;
            }
            if (guest.roomNumber == "Not Assigned")
            {
                Console.WriteLine("This guest has no active booking");
                return;
            }
            Room room = rooms.FirstOrDefault(r => r.roomNumber.ToString() == guest.roomNumber);

            if (room == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }
            Console.WriteLine("\nFinal Bill");
            Console.WriteLine($"Guest Name: {guest.guestName}");
            Console.WriteLine($"Room Number: {room.roomNumber}");
            Console.WriteLine($"Room Type: {room.roomType}");
            Console.WriteLine($"Check-In Date: {guest.checkInDate}");
            Console.WriteLine($"Total Nights: {guest.totalNights}");
            Console.WriteLine($"Price Per Night: {room.pricePerNight:F2}");
            Console.WriteLine($"Total Cost: {guest.calculateTotalCost(room.pricePerNight):F2}");


            Console.Write("\nConfirm checkout (Y/N): ");
            string answer = Console.ReadLine();

            if (answer.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                
                room.isAvailable = true;
                guests.Remove(guest);
                Console.WriteLine("\nCheckout completed successfully!");

                Console.WriteLine($"Guests Remaining: {guests.Count}");
                Console.WriteLine($"Rooms Total: {rooms.Count}");

                bool available = rooms.Any(r => r.roomNumber == room.roomNumber && r.isAvailable);

                Console.WriteLine($"Room {room.roomNumber} Available: {available}");
            }
            else
            {
                Console.WriteLine("Checkout cancelled.");
            }
        }

        //Case 12 Remove Unavailable Rooms
        public static void removeUnavailableRooms(List<Room> rooms, List<Guest> guests)
        {
        
            var removableRooms = rooms.Where(r => !r.isAvailable && !guests.Any(g => g.roomNumber == r.roomNumber.ToString()))
                .OrderBy(r => r.roomNumber);

            if (!removableRooms.Any())
            {
                Console.WriteLine("All unavailable rooms are currently occupied. No rooms can be decommissioned.");
                return;
            }

            Console.WriteLine("Rooms that can be removed:");
            foreach (var room in removableRooms)
            {
                Console.WriteLine($"Room {room.roomNumber}  {room.roomType}  OMR {room.pricePerNight:F2}");
            }

            Console.WriteLine($"\nTotal removable rooms: {removableRooms.Count()}");
            Console.Write("Remove these rooms? (Y/N): ");
            string answer = Console.ReadLine();
            if (!answer.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Operation cancelled.");
                return;
            }
            rooms.RemoveAll(r => !r.isAvailable && !guests.Any(g => g.roomNumber == r.roomNumber.ToString()));

            Console.WriteLine("\nRooms removed successfully.");
            Console.WriteLine($"Total Rooms Remaining: {rooms.Count}");
            Console.WriteLine("\nRemaining Rooms:");
            var remaining = rooms.Select(r => $"Room {r.roomNumber}  {r.roomType}");

            foreach (string room in remaining)
            {
                Console.WriteLine(room);
            }
        }

        //Case 13 Extend Guest Stay
        public static void extendGuestStay(List<Guest> guests, List<Room> rooms)
        {
            Console.Write("Enter Guest ID: ");
            string guestId = Console.ReadLine();
            Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);
            if (guest == null)
            {
                Console.WriteLine("Guest not found");
                return;
            }
            if (guest.roomNumber == "Not Assigned")
            {
                Console.WriteLine("This guest has no active booking to extend.");
                return;
            }
            Console.Write("Enter additional nights: ");
            if (!int.TryParse(Console.ReadLine(), out int additionalNights) || additionalNights <= 0)
            {
                Console.WriteLine("Invalid number of nights.");
                return;
            }
            guest.totalNights += additionalNights;
            Room room = rooms.FirstOrDefault(r => r.roomNumber.ToString() == guest.roomNumber);
            if (room == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            Console.WriteLine("\nStay extended successfully!");
            Console.WriteLine($"Guest: {guest.guestName}");
            Console.WriteLine($"Updated Total Nights: {guest.totalNights}");
            Console.WriteLine($"New Total Cost: OMR {guest.calculateTotalCost(room.pricePerNight):F2}");
        }


}


