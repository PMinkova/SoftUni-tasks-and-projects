namespace BookingApp.Models.Rooms
{
    using System;

    using Contracts;

    public abstract class Room : IRoom
    {
        private double pricePerNigth;

        protected Room(int bedCapacity)
        {
            this.BedCapacity = bedCapacity;
        }

        public int BedCapacity { get; private set; }

        public double PricePerNight
        {
            get => this.pricePerNigth;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }

                this.pricePerNigth = value;
            }
        }

        public void SetPrice(double price)
        {
            this.PricePerNight = price;
        }
    }
}
