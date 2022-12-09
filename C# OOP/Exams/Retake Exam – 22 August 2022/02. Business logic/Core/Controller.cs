namespace BookingApp.Core
{
    using System;
    using System.Linq;
    using System.Text;

    using Contracts;
    using Models.Bookings;
    using Models.Hotels;
    using Models.Hotels.Contacts;
    using Models.Rooms;
    using Models.Rooms.Contracts;
    using Repositories;
    using Repositories.Contracts;

    public class Controller : IController
    {
        private IRepository<IHotel> hotels;

        public Controller()
        {
            this.hotels = new HotelRepository();
        }
        public string AddHotel(string hotelName, int category)
        {
            if (this.hotels.Select(hotelName) != null)
            {
                return $"Hotel {hotelName} is already registered in our platform.";
            }

            var hotel = new Hotel(hotelName, category);
            this.hotels.AddNew(hotel);

            return
                $"{category} stars hotel {hotelName} is registered in our platform and expects room availability to be uploaded.";
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            var hotel = this.hotels.Select(hotelName);

            if (hotel == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }

            if (hotel.Rooms.Select(roomTypeName) != null)
            {
                return "Room type is already created!";
            }

            IRoom room;

            if (roomTypeName == nameof(Apartment))
            {
                room = new Apartment();
            }
            else if (roomTypeName == nameof(DoubleBed))
            {
                room = new DoubleBed();
            }
            else if (roomTypeName == nameof(Studio))
            {
                room = new Studio();
            }
            else
            {
                throw new ArgumentException("Incorrect room type!");
            }

            hotel.Rooms.AddNew(room);

            return $"Successfully added {roomTypeName} room type in {hotelName} hotel!";
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            var hotel = this.hotels.Select(hotelName);

            if (hotel == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }

            var incorrectRoomType = roomTypeName != nameof(DoubleBed)
                                    && roomTypeName != nameof(Apartment)
                                    && roomTypeName != nameof(Studio);

            if (incorrectRoomType)
            {
                throw new ArgumentException("Incorrect room type!");
            }

            var room = hotel.Rooms.Select(roomTypeName);

            if (room == null)
            {
                return "Room type is not created yet!";
            }

            if (room.PricePerNight > 0)
            {
                throw new InvalidOperationException("Price is already set!");
            }

            room.SetPrice(price);

            return $"Price of {roomTypeName} room type in {hotelName} hotel is set!";
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            var hotelsOfTheGivenCategory = this.hotels.All()
                .Where(h => h.Category == category)
                .ToList();

            if (!hotelsOfTheGivenCategory.Any())
            {
                return $"{category} star hotel is not available in our platform.";
            }

            var sortedHotels = hotelsOfTheGivenCategory
                .OrderBy(h => h.FullName)
                .ToList();

            IRoom selectedRoom = null;
            IHotel selectedHotel = null;

            foreach (var hotel in sortedHotels)
            {
                selectedRoom = hotel.Rooms.All()
                    .Where(r => r.PricePerNight > 0)
                    .OrderBy(r => r.BedCapacity)
                    .FirstOrDefault(r => r.BedCapacity >= children + adults);

                if (selectedRoom != null)
                {
                    selectedHotel = hotel;
                    break;
                }
            }

            if (selectedRoom == null)
            {
                return "We cannot offer appropriate room for your request.";
            }

            var bookingNumber = selectedHotel.Bookings.All().Count + 1;
            var newBooking = new Booking(selectedRoom, duration, adults, children, bookingNumber);

            selectedHotel.Bookings.AddNew(newBooking);

            return $"Booking number {bookingNumber} for {selectedHotel.FullName} hotel is successful!";
        }

        public string HotelReport(string hotelName)
        {
            var hotel = this.hotels.All().FirstOrDefault(h => h.FullName == hotelName);

            if (hotel == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }

            var sb = new StringBuilder();

            sb.AppendLine(hotel.ToString());

            if (!hotel.Bookings.All().Any())
            {
                sb.AppendLine("none");
            }
            else
            {
                foreach (var booking in hotel.Bookings.All())
                {
                    sb
                        .AppendLine(booking.BookingSummary())
                        .AppendLine();
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
