using System.Text.Json.Serialization;

namespace NasaWebPortal.DTO.Neo
{
    public class RelativeVelocity
    {
        [JsonPropertyName("kilometers_per_second")]
        public string KPS { get; set; }
        [JsonPropertyName("kilometers_per_hour")]
        public string KPH { get; set; }
        [JsonPropertyName("miles_per_hour")]
        public string MPH { get; set;}
    }
}
