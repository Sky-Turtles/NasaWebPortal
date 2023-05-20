using System.Text.Json.Serialization;

namespace NasaWebPortal.DTO.Neo
{
    public class Neo
    {
        [JsonPropertyName("near_earth_objects")]
        public ICollection<NeoData> NeoData { get; set; }
    }
}
