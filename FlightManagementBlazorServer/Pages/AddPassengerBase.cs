using DomainModel.Models;
using FlightManagementBlazorServer.Services;
using FlightManagementBlazorServer.ValidationModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Pages
{
    public class AddPassengerBase:ComponentBase
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
        public Passenger Passenger { get; set; }
        public NotificationDialog NotificationDialog { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
        public String ConcatenatedValidationErrors { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Passenger = new Passenger();
            Flight = await _flightService.GetFlightAsync(int.Parse(FlightId));
            Passenger.CheckIn = false;
            Passenger.Seat = "";
            Passenger.FlightId = Flight.Id;
        }

        protected async Task AddPassengerAsync()
        {
            ValidationErrors = ValidatePassenger();
            if (ValidationErrors.Any())
            {
                ConcatenatedValidationErrors = GetConcatenatedValidationErrors(ValidationErrors);
                NotificationDialog.Show();
            }
            else
            {
                await _passengerService.InsertPassengerAsync(Passenger);
                Close();
            }
        }

        protected void Close()
        {
            _navigationManager.NavigateTo("/PassengersPage");
        }

        protected List<ValidationError> ValidatePassenger()
        {
            var validationErrors = new List<ValidationError>();
            if (String.IsNullOrWhiteSpace(Passenger.Name))
                validationErrors.Add(new ValidationError { Description = "Please insert passenger name!" });
            if (String.IsNullOrWhiteSpace(Passenger.Surname))
                validationErrors.Add(new ValidationError { Description = "Please insert passenger surname!" });
            if (Passenger.Gender == null)
                validationErrors.Add(new ValidationError { Description = "Please select passenger gender!" });
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
