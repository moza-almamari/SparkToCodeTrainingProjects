using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    internal class Guest
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
}
