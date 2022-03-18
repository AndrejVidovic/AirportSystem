using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class PassengerRepository
    {
        private readonly AirportSystemContext _airportSystemContext;
        public PassengerRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }
        // passenger on flight 
        public List<Passenger> GetPassengersForFlight(string flightName,bool CheckIn)
        {
            return _airportSystemContext.Passengers.Include(passenger => passenger.Flight).Where(passenger => passenger.Flight.Number==flightName && passenger.CheckIn == CheckIn).ToList();
        }
        public void InsertPassenger(Passenger passenger)
        {
            _airportSystemContext.Passengers.Add(passenger);
            _airportSystemContext.SaveChanges();
        }
        // unique passenger for update/delete
        public Passenger GetPassenger(int id)
        {
            return _airportSystemContext.Passengers.FirstOrDefault(x => x.Id == id);
        }
        public void UpdatePassenger(Passenger passenger)
        {
            var passengerForUpdate = GetPassenger(passenger.Id);
            if(passengerForUpdate != null)
            {
                passengerForUpdate.Name = passenger.Name;
                passengerForUpdate.Surname = passenger.Surname;
                passengerForUpdate.Gender = passenger.Gender;
                passengerForUpdate.CheckIn = passenger.CheckIn;
                passengerForUpdate.Seat = passenger.Seat;
                passengerForUpdate.FlightId = passenger.FlightId;

                _airportSystemContext.SaveChanges();
            }
        }
        public void DeletePassenger(int id)
        {
            var passengerForDelete=GetPassenger(id);
            if(passengerForDelete != null)
            {
                _airportSystemContext.Passengers.Remove(passengerForDelete);
                _airportSystemContext.SaveChanges();
            }
        }
        public Passenger FindSeat(string seat,int flightId)
        {
            return _airportSystemContext.Passengers.FirstOrDefault(x => x.Seat == seat && x.FlightId==flightId);
        }
    }
}
