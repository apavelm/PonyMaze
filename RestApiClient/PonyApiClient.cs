using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using PonyMaze.Common;
using RestApiClient.Classes;
using RestApiClient.Exceptions;

namespace RestApiClient
{
    public class PonyApiClient
    {
        public PonyApiClient()
        {

        }

        private HttpClient GetClient()
        {
            return new HttpClient()
            {
                BaseAddress = new Uri(Constants.BASEAPI_URL),
                DefaultRequestHeaders = {Accept = {new MediaTypeWithQualityHeaderValue("application/json")}}
            };
        }

        public async Task<Guid> CreateMaze(int width, int height, string playerName, int difficulty)
        {
            var request = new CreateMazeRequest()
            {
                Difficulty = difficulty,
                Width = width,
                Height = height,
                PlayerName = playerName
            };

            using (var client = GetClient())
            {
                var content = new StringContent(JObject.FromObject(request).ToString(), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("pony-challenge/maze", content);

                var responseDataString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var jObj = JObject.Parse(responseDataString);
                        var serializedObj = jObj.ToObject<CreateMazeResponse>();
                        return serializedObj.MazeId;
                    }
                    catch
                    {
                        throw new Exception("CreateMaze: Received invalid json data");
                    }
                }
                else
                {
                    throw new PonyClientException(responseDataString);
                }
            }
        }

        public async Task<MazeState> GetMazeCurrentState(Guid mazeId)
        {
            using (var client = GetClient())
            {
                var response = await client.GetAsync($"pony-challenge/maze/{mazeId}");

                var responseDataString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var jObj = JObject.Parse(responseDataString);
                        var serializedObj = jObj.ToObject<GetMazeStateResponse>();
                        return new MazeState()
                        {
                            Difficulty = serializedObj.Difficulty,
                            MazeId = serializedObj.MazeId,
                            Domokun = serializedObj.Enemies.First(),
                            Pony = serializedObj.Heroes.First(),
                            Exit = serializedObj.Exits.First(),
                            HiddenImageUrl = serializedObj.GameState.ImageUrl,
                            MazeHeight = serializedObj.Size[1],
                            MazeWidth = serializedObj.Size[0],
                            State = serializedObj.GameState.State,
                            MazeStateResult = serializedObj.GameState.Result,
                            Cells = serializedObj.Cells.Select(s => s.ToMazeCell()).ToList()
                        };
                    }
                    catch
                    {
                        throw new Exception("GetMazeCurrentState: Received invalid json data");
                    }
                }
                else
                {
                    throw new PonyClientException(responseDataString);
                }
            }
        }

        public async Task<string> GetPrintedMaze(Guid mazeId)
        {
            using (var client = GetClient())
            {
                var response = await client.GetAsync($"pony-challenge/maze/{mazeId}/print");

                var responseDataString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return responseDataString;
                }
                else
                {
                    throw new PonyClientException(responseDataString);
                }
            }
        }

        public async Task<byte[]> LoadImage(string imageUrl)
        {
            using (var client = GetClient())
            {
                var response = await client.GetAsync(imageUrl);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsByteArrayAsync();
                    return data;
                }
                else
                {
                    throw new Exception("Unable to load image");
                }
            }
        }

        public async Task<MakeMoveResponse> MakeMove(Guid mazeId, Direction direction)
        {
            var request = new MakeMoveRequest()
            {
                Direction = direction
            };

            using (var client = GetClient())
            {
                var content = new StringContent(JObject.FromObject(request).ToString(), Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"pony-challenge/maze/{mazeId}", content);

                var responseDataString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var jObj = JObject.Parse(responseDataString);
                        return jObj.ToObject<MakeMoveResponse>();
                    }
                    catch
                    {
                        throw new Exception("MakeMove: Received invalid json data");
                    }
                }
                else
                {
                    throw new PonyClientException(responseDataString);
                }
            }
        }
    }
}
