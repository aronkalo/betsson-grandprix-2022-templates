using System.Text.Json.Serialization;

namespace Hacathon.NET.Models
{
    public class Map
    {
        [JsonPropertyName("width")]
        public int Width { get; init; }
        
        [JsonPropertyName("height")]
        public int Height { get; init; }
        
        [JsonPropertyName("grid")]
        public int[] Grid { get; init; }
    }
}