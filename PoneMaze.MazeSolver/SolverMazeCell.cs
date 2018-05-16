using PonyMaze.Common;

namespace PoneMaze.MazeSolver
{
    public class SolverMazeCell
    {
        public SolverMazeCell()
        {
            Walls = MazeCell.None;
            Value = -1;
        }

        public MazeCell Walls { get; set; }

        public int Value { get; set; }

        public bool CanGoWest()
        {
            return !Walls.HasFlag(MazeCell.West);
        }

        public bool CanGoEast()
        {
            return !Walls.HasFlag(MazeCell.East);
        }

        public bool CanGoNorth()
        {
            return !Walls.HasFlag(MazeCell.North);
        }

        public bool CanGoSouth()
        {
            return !Walls.HasFlag(MazeCell.South);
        }
    }
}