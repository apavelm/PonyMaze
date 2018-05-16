using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestApiClient;
using RestApiClient.Exceptions;

namespace ApiClient.Tests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public async Task CreateMazeWithError()
        {
            var client = new PonyApiClient();

            // Wrong size: width
            await Assert.ThrowsExceptionAsync<PonyClientException>(async () =>
            {
                await client.CreateMaze(10, 20, "Rainbow Dash", 5);
            });

            // Wrong size: height
            await Assert.ThrowsExceptionAsync<PonyClientException>(async () =>
            {
                await client.CreateMaze(20, 10, "Rainbow Dash", 5);
            });

            // Wrong name
            await Assert.ThrowsExceptionAsync<PonyClientException>(async () =>
            {
                await client.CreateMaze(20, 20, "blabla", 5);
            });

            // Wrong difficulty
            await Assert.ThrowsExceptionAsync<PonyClientException>(async () =>
            {
                await client.CreateMaze(20, 20, "Rainbow Dash", 100);
            });

        }

        [TestMethod]
        public async Task CreateMazeAndGetState()
        {
            var client = new PonyApiClient();

            var mazeId = await client.CreateMaze(20, 20, "Rainbow Dash", 5);
            Assert.AreNotEqual(mazeId, Guid.Empty, "Error: Maze created with Guid.Empty is ID");

            var state = await client.GetMazeCurrentState(mazeId);
            Assert.IsNotNull(state, "Error: state serialization error");
        }
    }
}
