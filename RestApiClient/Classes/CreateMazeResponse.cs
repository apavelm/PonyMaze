using System;
using Newtonsoft.Json;

namespace RestApiClient.Classes
{
    public class CreateMazeResponse
    {
        [JsonProperty("maze_id")]
        public Guid MazeId { get; set; }
    }
}