using Newtonsoft.Json;

namespace RestApiClient.Classes
{
    public class MakeMoveResponse
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state-result")]
        public string Result { get; set; }

        [JsonProperty("hidden-url")]
        public string ImageUrl { get; set; }
    }
}