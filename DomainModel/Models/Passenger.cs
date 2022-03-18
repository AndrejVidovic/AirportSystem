using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Seat { get; set; }
        public bool CheckIn { get; set; }
        public int? FlightId { get; set; }
        public Flight Flight { get;set; }
    }
}
