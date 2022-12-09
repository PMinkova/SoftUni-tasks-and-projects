namespace BookingApp.Models.Hotels
{
    using System;
    using System.Text;
    using Bookings.Contracts;
    using Contacts;
    using Repositories;
    using Repositories.Contracts;
    using Rooms.Contracts;

    public class Hotel : IHotel
    {
        private const int MinCategory = 1;
        private const int MaxCategory = 5;

        private string fullName;
        private int category;

        public Hotel(string fullName, int category)
            : this()
        {
            this.FullName = fullName;
            this.Category = category;
        }

        private Hotel()
        {
            this.Rooms = new RoomRepository();
            this.Bookings = new BookingRepository();
        }

        public string FullName
        {
            get => this.fullName;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hotel name cannot be null or empty!");
                }

                this.fullName = value;
            }
        }

        public int Category
        {
            get => this.category;
            private set
            {
                if (value < MinCategory || MaxCategory < value)
                {
                    throw new ArgumentException("Category should be between 1 and 5 stars!");
                }

                this.category = value;
            }
        }

        public double Turnover
        {
            get
            {
                var turnOver = 0d;

                foreach (var booking in this.Bookings.All())
                {
                    turnOver += booking.ResidenceDuration * booking.Room.PricePerNight;
                }

                return Math.Round(turnOver, 2);
            }
        }


        public IRepository<IRoom> Rooms { get; }

        public IRepository<IBooking> Bookings { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"Hotel name: {this.FullName}")
                .AppendLine($"--{this.Category} star hotel")
                .AppendLine($"--Turnover: {this.Turnover:F2} $")
                .AppendLine("--Bookings:");

            return sb.ToString();
        }
    }
}
