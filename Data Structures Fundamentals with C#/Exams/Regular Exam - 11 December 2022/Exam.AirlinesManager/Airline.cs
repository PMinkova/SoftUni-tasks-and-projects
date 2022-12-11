namespace Exam.DeliveriesManager
{
    using System.Collections.Generic;

    public class Airline
    {
        public Airline(string id, string name, double rating) 
            : this()
        {
            Id = id;
            Name = name;
            Rating = rating;
        }

        private Airline()
        {
            this.Flights = new HashSet<Flight>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public double Rating { get; set; }

        public HashSet<Flight> Flights { get; set; }
    }
}
