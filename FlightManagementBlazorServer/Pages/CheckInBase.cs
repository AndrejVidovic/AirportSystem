using DomainModel.Models;
using FlightManagementBlazorServer.Services;
using FlightManagementBlazorServer.ValidationModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Pages
{
    public class CheckInBase : ComponentBase
    {
        [Inject]
        PassengerService _passengerService { get; set; }

        [Inject]
        FlightService _flightService { get; set; }

        [Inject]
        NavigationManager _navigationManager { get; set; }
    
        [Parameter]
        public string FlightId { get; set; }

        public NotificationDialog NotificationDialog { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
        public String ConcatenatedValidationErrors { get; set; }
        public bool ShowDialog { get; set; }
        public Flight Flight { get; set; }
        public List<Passenger> Passengers;
        public string SelectedFlight { get; set; }
        public Passenger SelectedPassenger { get; set; }
        public string Seat { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Flight = await _flightService.GetFlightAsync(int.Parse(FlightId));
            SelectedFlight = Flight.Number;
            Passengers = await _passengerService.GetPassengersForFlightAsync(SelectedFlight);

        }
        protected void Close()
        {
            _navigationManager.NavigateTo("/CheckInPage");
        }
        protected async Task SelectSeat(Passenger passenger)
        {
            ShowDialog = true;
            SelectedPassenger = passenger;
        }

        protected async Task IsSeatSelected(bool isSeatConfirmed)
        {
            ValidationErrors = ValidateSeat();

            if (isSeatConfirmed)
            {
                var SeatFree = _passengerService.FindSeat(Seat,int.Parse(FlightId));
                if (await SeatFree == HttpStatusCode.OK)
                {
                    ShowDialog = false;
                    SelectedPassenger.CheckIn = true;
                    SelectedPassenger.Seat = Seat;
                    await _passengerService.UpdatePassengerAsync(SelectedPassenger);
                    Passengers = await _passengerService.GetPassengersForFlightAsync(SelectedFlight);
                }
                else
                {
                    ConcatenatedValidationErrors = GetConcatenatedValidationErrors(ValidationErrors);
                    NotificationDialog.Show();
                }
            }
            else
            {
                ShowDialog = false;
            }
        }
        protected List<ValidationError> ValidateSeat()
        {
            var validationErrors = new List<ValidationError>();
            validationErrors.Add(new ValidationError { Description = "Seat is already taken!" });
            return validationErrors;

        }
        protected string GetConcatenatedValidationErrors(List<ValidationError> ValidationErrors)
        {
            StringBuilder message = new StringBuilder();
            foreach (var error in ValidationErrors)
            {
                if (message.Length == 0)
                    message.Append(error.Description);
                else
                    message.Append($"{Environment.NewLine} {error.Description}");

            }
            return message.ToString();
        }

    }
}
