using System;


namespace PonyMaze.Common
{
    [Flags]
    public enum MazeCell
    {
        None = 0,
        North = 1,
        South = 2,
        East = 4,
        West = 8
    }

}
