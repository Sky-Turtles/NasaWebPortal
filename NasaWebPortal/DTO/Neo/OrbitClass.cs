using System.Text.Json.Serialization;

namespace NasaWebPortal.DTO.Neo
{
    public class OrbitClass
    {
        [JsonPropertyName("orbit_class_type")]
        public string OrbitClassType { get; set; }
        [JsonPropertyName("orbit_class_description")]
        public string OrbitClassDescription { get; set; }
        [JsonPropertyName("orbit_class_range")]
        public string OrbitClassRange { get; set; }
    }
}
