using DomainModel.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44334/api/User";
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<User> LoginAsync(string username,string password)
        {
            var user= await _httpClient.GetFromJsonAsync<User>($"{BaseApiUrl}/{username}");
            if (user != null && user.Password == password)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        public async Task AddUserAsync(User user)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(user),Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
    }
}
