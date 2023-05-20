using System.Text.Json.Serialization;

namespace NasaWebPortal.DTO
{
    public class AstroPic
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("explanation")]
        public string Explanation { get; set; }
    }
}
