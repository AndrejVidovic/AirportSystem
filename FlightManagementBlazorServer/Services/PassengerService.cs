using DomainModel.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FlightManagementBlazorServer.Services
{
    public class PassengerService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44334/api/Passenger";

        public PassengerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Passenger>> GetPassengersForFlightAsync(string flightName)
        {
            return await _httpClient.GetFromJsonAsync<List<Passenger>>($"{BaseApiUrl}/{flightName}");
        }
        public async Task InsertPassengerAsync(Passenger passenger)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(passenger),Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Passenger> GetPassengerAsync(int passengerId)
        {
            return await _httpClient.GetFromJsonAsync<Passenger>($"{BaseApiUrl}/{passengerId}");
        }
        public async Task UpdatePassengerAsync(Passenger passenger)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(passenger), Encoding.UTF8, "application/json"); 
            await _httpClient.SendAsync(request);
        }
        public async Task DeletePassengerAsync(int passengerId)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{passengerId}");
            await _httpClient.SendAsync(request);
        }
        public async Task<List<Passenger>> GetPassengerForFlightAndCheckInAsync(string flightName)
        {
            return await _httpClient.GetFromJsonAsync<List<Passenger>>($"{BaseApiUrl}/CheckIn/{flightName}");
        }
        public async Task<HttpStatusCode> FindSeat(string seat,int flightId)
        {
            var response = await _httpClient.GetAsync($"{BaseApiUrl}/seat/{seat}/{flightId}");
            //Debug.WriteLine("VRIJEDNOST DEBUG"+response);
            return response.StatusCode;
           
        }
        
    }
}
