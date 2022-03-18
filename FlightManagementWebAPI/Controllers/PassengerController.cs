using DomainModel.Models;
using FlightManagementWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly PassengerRepository _passengerRepository;
        public PassengerController(PassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }
        [HttpGet("{flightName}")]
        public IActionResult GetPassengersForFlight(string flightName)
        {
            try
            {
                
                    return Ok(_passengerRepository.GetPassengersForFlight(flightName,false));
                
                
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("CheckIn/{flightName}")]
        public IActionResult GetPassengersForFlightAndCheckIn(string flightName)
        {
            try
            {
                return Ok(_passengerRepository.GetPassengersForFlight(flightName,true));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{passengerId:int}")]
        public IActionResult GetPassenger(int passengerId)
        {
            try
            {
                return Ok(_passengerRepository.GetPassenger(passengerId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult InsertPassenger([FromBody] Passenger passenger)
        {
            if(passenger == null)
            {
                return BadRequest();
            }
            try
            {
                _passengerRepository.InsertPassenger(passenger);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdatePassenger([FromBody] Passenger passenger)
        {
            if(passenger == null)
            {
                return BadRequest();
            }
            try
            {
                _passengerRepository.UpdatePassenger(passenger);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{passengerId:int}")]
        public IActionResult DeletePassenger(int passengerId)
        {
            try
            {
                _passengerRepository.DeletePassenger(passengerId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("seat/{seat}/{flightId:int}")]
        public IActionResult FindSeat(string seat,int flightId)
        {
            try
            {
                var userSeat=_passengerRepository.FindSeat(seat,flightId);
                if (userSeat == null)
                {
                     return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status302Found);
                }
                
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
