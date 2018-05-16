using Newtonsoft.Json;
using PonyMaze.Common;

namespace RestApiClient.Classes
{
    public class MakeMoveRequest
    {
        [JsonProperty("direction")]
        public Direction Direction { get; set; }
    }
}