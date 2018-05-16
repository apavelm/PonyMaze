using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PonyMaze.Common;

namespace RestApiClient.Classes
{
    public class GetMazeStateResponse
    {
        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty("pony")]
        public List<int> Heroes { get; set; }

        [JsonProperty("domokun")]
        public List<int> Enemies { get; set; }

        [JsonProperty("end-point")]
        public List<int> Exits { get; set; }

        [JsonProperty("size")]
        public List<int> Size { get; set; }

        [JsonProperty("maze_id")]
        public Guid MazeId { get; set; }

        [JsonProperty("game-state")]
        public MakeMoveResponse GameState { get; set; }

        [JsonProperty("data")]
        public List<CellData> Cells { get; set; }
    }
}
