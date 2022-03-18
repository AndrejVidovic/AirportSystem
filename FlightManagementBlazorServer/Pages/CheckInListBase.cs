using DomainModel.Models;
using FlightManagementBlazorServer.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Pages
{
    public class CheckInListBase:ComponentBase
    {
        [Inject] 
        PassengerService _passengerService { get; set; }
        [Inject] 
        FlightService _flightService { get; set; }
        [Inject] 
        NavigationManager _navigationManager { get; set; }
        [Parameter]
        public string FlightId { get; set; }

        public Flight Flight { get; set; }
        public List<Passenger> Passengers;
        public string SelectedFlight { get; set; }
        public int SelectedPassengerId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Flight = await _flightService.GetFlightAsync(int.Parse(FlightId));
            SelectedFlight = Flight.Number;
            Passengers = await _passengerService.GetPassengerForFlightAndCheckInAsync(SelectedFlight);

        }
        protected void Close()
        {
            _navigationManager.NavigateTo("/CheckInPage");
        }
    }
}
