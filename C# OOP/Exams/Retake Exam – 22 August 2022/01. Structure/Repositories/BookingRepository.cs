namespace BookingApp.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Models.Bookings.Contracts;

    public class BookingRepository : IRepository<IBooking>
    {
        public readonly List<IBooking> bookings;

        public BookingRepository()
        {
            this.bookings = new List<IBooking>();
        }

        public void AddNew(IBooking model)
        {
            this.bookings.Add(model);
        }

        public IBooking Select(string bookingNumber)
        {
            return this.bookings.FirstOrDefault(b => b.BookingNumber.ToString() == bookingNumber);
        }

        public IReadOnlyCollection<IBooking> All()
        {
            return this.bookings.AsReadOnly();
        }
    }
}
