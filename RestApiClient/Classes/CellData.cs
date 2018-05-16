using System.Collections.Generic;
using PonyMaze.Common;

namespace RestApiClient.Classes
{
    public class CellData: List<string>
    {
        public MazeCell ToMazeCell()
        {
            var flags = MazeCell.None;
            
            if (base.Contains("north") || base.Contains("North"))
                flags |= MazeCell.North;
            if (base.Contains("south") || base.Contains("South"))
                flags |= MazeCell.South;
            if (base.Contains("east") || base.Contains("East"))
                flags |= MazeCell.East;
            if (base.Contains("west") || base.Contains("West"))
                flags |= MazeCell.West;

            return flags;
        }
    }
}
