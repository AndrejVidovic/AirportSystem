using DomainModel.Models;
using FlightManagementBlazorServer.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Pages
{
    public class CheckInPageBase:ComponentBase
    {

        [Inject] 
        FlightService _flightService { get; set; }

        public List<Flight> Flights;

        protected override async Task OnInitializedAsync()
        {
            Flights = await _flightService.GetFlights();
        }
    }
}
