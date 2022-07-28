using System.Text.Json.Serialization;

namespace Hacathon.NET.Models
{
    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        [JsonPropertyName("x")]
        public int X { get; }
        
        [JsonPropertyName("y")]
        public int Y { get; }
    }
}