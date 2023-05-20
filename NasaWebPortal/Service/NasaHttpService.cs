using NasaWebPortal.DTO;
using NasaWebPortal.DTO.Neo;
using System.Net.Http.Json;

namespace NasaWebPortal.Service
{
    public class NasaHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly string NasaApiKey = "drMbNmPcLEHLab14wVameNZrG3jogEyLW4c0FIkL";
        public NasaHttpService()
        {
            _httpClient = new();
        }

        public async Task<AstroPic> CallAPOD()
        {
            HttpResponseMessage data = await _httpClient.GetAsync("https://api.nasa.gov/planetary/apod?api_key=" + NasaApiKey);
            data.EnsureSuccessStatusCode();
            var cleanData = await data.Content.ReadFromJsonAsync<AstroPic>();
            return cleanData;
        }

        public async Task<Neo> GetNeoDataAsync()
        {
            HttpResponseMessage data = await _httpClient.GetAsync("https://api.nasa.gov/neo/rest/v1/neo/browse?api_key=" + NasaApiKey);
            data.EnsureSuccessStatusCode();
            var cleanData = await data.Content.ReadFromJsonAsync<Neo>();
            return cleanData;
        }
    }
}
