using Newtonsoft.Json;

namespace RestApiClient.Classes
{
    public class CreateMazeRequest
    {
        [JsonProperty("maze-width")]
        public int Width { get; set; }

        [JsonProperty("maze-height")]
        public int Height { get; set; }

        [JsonProperty("maze-player-name")]
        public string PlayerName { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }
    }
}