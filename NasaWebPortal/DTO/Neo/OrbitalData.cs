using System.Text.Json.Serialization;

namespace NasaWebPortal.DTO.Neo
{
    public class OrbitalData
    {
        [JsonPropertyName("orbit_id")]
        public string OrbitalId { get; set; }
        [JsonPropertyName("orbit_determination_date")]
        public string OrbitDeterminationDate { get; set; }
        [JsonPropertyName("orbit_class")]
        public OrbitClass OrbitClass { get; set; }
    }
}
