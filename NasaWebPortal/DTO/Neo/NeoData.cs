using System.Text.Json.Serialization;

namespace NasaWebPortal.DTO.Neo
{
    public class NeoData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("name_limited")]
        public string NameLimited { get; set; }
        [JsonPropertyName("designation")]
        public string Designation { get; set; }
        [JsonPropertyName("is_potentially_hazordous_astroid")]
        public bool IsPotentiallyHazardousAsteroid { get; set; }
        [JsonPropertyName("close_approach_data")]
        public ICollection<CloseApproachData> CloseApproachData { get; set; }
        [JsonPropertyName("orbital_data")]
        public OrbitalData OrbitalData { get; set; }
    }
}
