using Microsoft.AspNetCore.Components;
using DomainModel.Models;
using FlightManagementBlazorServer.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Pages
{
    public class PassengersListBase:ComponentBase
    {
        [Parameter]
        public string FlightId { get; set; }
        [Inject]
        PassengerService _passengerService { get; set; }
        [Inject]
        FlightService _flightService { get; set; }
        [Inject]
        NavigationManager _navigationManager { get; set; }

        public Flight Flight { get; set; }
        public List<Passenger> Passengers;
        public ConfirmationDialog DeleteConfirmationDialog { get; set; }
        public ConfirmationDialog ArchiveConfirmationDialog { get; set; }
        public string SelectedFlight { get; set; }
        public int SelectedPassengerId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Flight = await _flightService.GetFlightAsync(int.Parse(FlightId));
            SelectedFlight = Flight.Number;
            Passengers = await _passengerService.GetPassengersForFlightAsync(SelectedFlight);

        }
        protected void Close()
        {
            _navigationManager.NavigateTo("/PassengersPage");
        }


        protected async Task DeletePassenger(int passengerId)
        {
            SelectedPassengerId = passengerId;
            DeleteConfirmationDialog.Show();
        }

        protected async Task OnDeleteConfirmationSelected(bool isDeleteConfirmed)
        {
            if (isDeleteConfirmed)
            {
                await _passengerService.DeletePassengerAsync(SelectedPassengerId);
                Passengers = await _passengerService.GetPassengersForFlightAsync(SelectedFlight);
            }
        }
    }
}
