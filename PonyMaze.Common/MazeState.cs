using System;
using System.Collections.Generic;

namespace PonyMaze.Common
{
    public class MazeState
    {
        public int Difficulty { get; set; }

        public int Pony { get; set; }

        public int Domokun { get; set; }

        public int Exit { get; set; }

        public int MazeWidth { get; set; }
        public int MazeHeight { get; set; }

        public Guid MazeId { get; set; }

        public string State { get; set; }

        public string MazeStateResult { get; set; }

        public string HiddenImageUrl { get; set; }

        public List<MazeCell> Cells { get; set; }
    }
}