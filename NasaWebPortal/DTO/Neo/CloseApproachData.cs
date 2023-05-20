using System.Text.Json.Serialization;

namespace NasaWebPortal.DTO.Neo
{
    public class CloseApproachData
    {
        [JsonPropertyName("orbiting_body")]
        public string OrbitingBody { get; set; }
        [JsonPropertyName("relative_velocity")]
        public RelativeVelocity RelativeVelocity { get; set; }
        [JsonPropertyName("miss_distance")]
        public MissDistance MissDistance { get; set; }
        public bool IsVisable { get; set; } = false;

    }
}
