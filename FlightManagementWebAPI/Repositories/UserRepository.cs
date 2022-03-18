using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class UserRepository
    { 
        private readonly AirportSystemContext _airportSystemContext;
        public UserRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }
        public void InsertUser(User user)
        {
            _airportSystemContext.Users.Add(user);
            _airportSystemContext.SaveChanges();
        }
        public User Login(string username)
        {
            var user= _airportSystemContext.Users.FirstOrDefault(x => x.Username == username);
            if(user != null)
            {
                return  user;
            }
            else
            {
                return null;
            }
        }
    }
}
