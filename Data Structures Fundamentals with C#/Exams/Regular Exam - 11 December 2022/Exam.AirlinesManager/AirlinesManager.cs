namespace Exam.DeliveriesManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AirlinesManager : IAirlinesManager
    {
        private HashSet<Airline> airlines;
        private HashSet<Flight> flights;

        public AirlinesManager()
        {
            this.airlines = new HashSet<Airline>();
            this.flights = new HashSet<Flight>();
        }

        public void AddAirline(Airline airline)
        {
            this.airlines.Add(airline);
        }

        public void AddFlight(Airline airline, Flight flight)
        {
            if (!this.airlines.Contains(airline))
            {
                throw new ArgumentException();
            }

            airline.Flights.Add(flight);
            this.flights.Add(flight);
            flight.Airline = airline;
        }

        public bool Contains(Airline airline)
        {
            return this.airlines.Contains(airline);
        }

        public bool Contains(Flight flight)
        {
            return this.flights.Contains(flight);
        }

        public void DeleteAirline(Airline airline)
        {
            if (!this.airlines.Contains(airline))
            {
                throw new ArgumentException();
            }

            this.flights = this.flights.Where(f => f.Airline.Name != airline.Name).ToHashSet();

            this.airlines.Remove(airline);
        }

        public IEnumerable<Airline> GetAirlinesOrderedByRatingThenByCountOfFlightsThenByName()
        {
            return this.airlines.OrderByDescending(x => x.Rating)
                .ThenByDescending(a => a.Flights.Count)
                .ThenBy(a => a.Name);
        }

        public IEnumerable<Airline> GetAirlinesWithFlightsFromOriginToDestination(string origin, string destination)
        {
            return this.airlines
                .Where(a => a.Flights
                    .Any(f => !f.IsCompleted && f.Origin == origin && f.Destination == destination));
        }

        public IEnumerable<Flight> GetAllFlights()
        {
            return this.flights;
        }

        public IEnumerable<Flight> GetCompletedFlights()
        {
            return this.flights.Where(f => f.IsCompleted);
        }

        public IEnumerable<Flight> GetFlightsOrderedByCompletionThenByNumber()
        {
            return this.flights
                .OrderBy(f => f.IsCompleted)
                .ThenBy(f => f.Number);
        }

        public Flight PerformFlight(Airline airline, Flight flight)
        {
            if (!this.airlines.Contains(airline) || !this.flights.Contains(flight))
            {
                throw new ArgumentException();
            }

            flight.IsCompleted = true;

            return flight;
        }
    }
}
