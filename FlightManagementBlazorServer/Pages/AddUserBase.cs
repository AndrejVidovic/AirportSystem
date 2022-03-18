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
    public class AddUserBase:ComponentBase
    {
        [Inject] 
        UserService _userService { get; set; }
       
        public User User { get; set; }
        public string[] roles = { "Admin", "CheckIn" };
        public NotificationDialog NotificationDialog { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
        public List<ValidationError> UserAddedInfo { get; set; }
        public String ConcatenatedValidationErrors { get; set; }

        protected override async Task OnInitializedAsync()
        {
            User = new User();
        }

        protected async Task AddUserAsync()
        {
            ValidationErrors = ValidateUser();
            UserAddedInfo = UserAdded();
            if (ValidationErrors.Any())
            {
                ConcatenatedValidationErrors = GetConcatenatedValidationErrors(ValidationErrors);
                NotificationDialog.Show();
            }
            else
            {
                ConcatenatedValidationErrors = GetConcatenatedValidationErrors(UserAddedInfo);
                NotificationDialog.Show();
                await _userService.AddUserAsync(User);
            }
        }

        protected List<ValidationError> ValidateUser()
        {
            var validationErrors = new List<ValidationError>();
            if (String.IsNullOrWhiteSpace(User.Username))
                validationErrors.Add(new ValidationError { Description = "Please insert username!" });
            if (String.IsNullOrWhiteSpace(User.Password))
                validationErrors.Add(new ValidationError { Description = "Please insert password!" });
            if (User.Role == null)
                validationErrors.Add(new ValidationError { Description = "Please select role!" });
            return validationErrors;
        }
        protected List<ValidationError> UserAdded()
        {
            var validationErrors = new List<ValidationError>();
            validationErrors.Add(new ValidationError { Description = "User successfully added!" });
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
