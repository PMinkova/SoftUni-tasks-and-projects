namespace BookingApp.Models.Bookings
{
    using System;
    using System.Text;
    using Contracts;
    using Rooms.Contracts;

    public class Booking : IBooking
    {
        private int residenceDuration;
        private int adultsCount;
        private int childrenCount;

        public Booking(IRoom room, int residenceDuration, int adultsCount, int childrenCount, int bookingNumber)
        {
            this.Room = room;
            this.ResidenceDuration = residenceDuration;
            this.AdultsCount = adultsCount;
            this.ChildrenCount = childrenCount;
            this.BookingNumber = bookingNumber;
        }

        public IRoom Room { get; private set; }

        public int ResidenceDuration
        {
            get => this.residenceDuration;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Duration cannot be negative or zero!");
                }

                this.residenceDuration = value;
            }
        }

        public int AdultsCount
        {
            get => this.adultsCount;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Adults count cannot be negative or zero!");
                }

                this.adultsCount = value;
            }
        }

        public int ChildrenCount
        {
            get => this.childrenCount;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Children count cannot be negative!");
                }
                this.childrenCount = value;
            }
        }
        public int BookingNumber { get; }

        public string BookingSummary()
        {
            var sb = new StringBuilder();

            var totalAmountPaid = Math.Round(this.ResidenceDuration * this.Room.PricePerNight, 2);

            sb
                .AppendLine($"Booking number: {this.BookingNumber}")
                .AppendLine($"Room type: {this.Room.GetType().Name}")
                .AppendLine($"Adults: {this.AdultsCount} Children: {this.ChildrenCount}")
                .AppendLine($"Total amount paid: {totalAmountPaid:F2} $");

            return sb.ToString().TrimEnd();
        }
    }
}
