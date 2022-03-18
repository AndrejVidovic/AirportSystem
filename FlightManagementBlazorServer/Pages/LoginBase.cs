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
    public class LoginBase:ComponentBase
    {
        [Inject]
        private NavigationManager _navigationManager { get; set; }
        [Inject]
        private UserService _userService { get; set; }

        [Inject]
        private AppState AppState { get; set; }

        public User User { get; set; }
        public User LoggedUser { get; set; }
        public NotificationDialog NotificationDialog { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
        public List<ValidationError> WrongUserError { get; set; }
        public String ConcatenatedValidationErrors { get; set; }

        protected override async Task OnInitializedAsync()
        {
            User = new User();
            LoggedUser = new User();
        }

        protected  async Task LoginAsync()
        {
            ValidationErrors = ValidateLogin();
            WrongUserError = WrongUser();
            if (ValidationErrors.Any())
            {
                ConcatenatedValidationErrors = GetConcatenatedValidationErrors(ValidationErrors);
                NotificationDialog.Show();
            }
            else
            {
                LoggedUser = await _userService.LoginAsync(User.Username, User.Password);
                if (LoggedUser != null)
                {
                    AppState.LoggedIn = LoggedUser.Role;
                    _navigationManager.NavigateTo("/FlightList");

                }
                else
                {
                    ConcatenatedValidationErrors = GetConcatenatedValidationErrors(WrongUserError);
                    NotificationDialog.Show();
                }

            }
        }
        protected List<ValidationError> ValidateLogin()
        {
            var validationErrors = new List<ValidationError>();
            if (String.IsNullOrWhiteSpace(User.Username))
                validationErrors.Add(new ValidationError { Description = "Please insert username!" });

            if (String.IsNullOrWhiteSpace(User.Password))
                validationErrors.Add(new ValidationError { Description = "Please insert password!" });

            return validationErrors;

        }
        protected List<ValidationError> WrongUser()
        {
            var validationErrors = new List<ValidationError>();
            validationErrors.Add(new ValidationError { Description = "Wrong username or password!" });
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
