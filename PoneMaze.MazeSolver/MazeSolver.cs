using System.Collections.Generic;
using PonyMaze.Common;

namespace PoneMaze.MazeSolver
{
    public class MazeSolver
    {
        private readonly List<string> _solutions = new List<string>();
        private SolverMazeCell[,] _solverField;

        protected MazeSolver()
        {
        }

        public MazeCell[,] Field { get; private set; }

        public Point PonyLocation { get; set; }
        public Point DomokunLocation { get; set; }
        public Point ExitLocation { get; private set; }

        public static MazeSolver Load(MazeState state)
        {
            var instance = new MazeSolver();
            var newField = new MazeCell[state.MazeWidth, state.MazeHeight];
            instance._solverField = new SolverMazeCell[state.MazeWidth, state.MazeHeight];

            for (var i = 0; i < state.Cells.Count; i++)
            {
                var x = i % state.MazeWidth;
                var y = i / state.MazeWidth;
                newField[x, y] = state.Cells[i];
                instance._solverField[x, y] = new SolverMazeCell {Walls = newField[x, y]};

                if (x == state.MazeWidth - 1 || state.Cells[i + 1].HasFlag(MazeCell.West))
                    instance._solverField[x, y].Walls |= MazeCell.East;

                if (y == state.MazeHeight - 1 || state.Cells[i + state.MazeWidth].HasFlag(MazeCell.North))
                    instance._solverField[x, y].Walls |= MazeCell.South;

                if (i == state.Domokun) instance.DomokunLocation = new Point(x, y);
                if (i == state.Exit) instance.ExitLocation = new Point(x, y);
                if (i == state.Pony) instance.PonyLocation = new Point(x, y);
            }

            instance.Field = newField;
            return instance;
        }

        public List<string> Solve()
        {
            _solutions.Clear();

            SolveMaze(PonyLocation.x, PonyLocation.y, 0, "");

            return _solutions;
        }

        public void SolveMaze(int x, int y, int step, string path)
        {
            if (_solverField[x, y].Value > -1 && _solverField[x, y].Value < step) return;

            if (x == ExitLocation.x && y == ExitLocation.y)
            {
                _solutions.Add(path);
                return;
            }

            _solverField[x, y].Value = step;

            if (_solverField[x, y].CanGoEast())
                SolveMaze(x + 1, y, step + 1, path + "E");

            if (_solverField[x, y].CanGoNorth())
                SolveMaze(x, y-1, step + 1, path + "N");

            if (_solverField[x, y].CanGoWest())
                SolveMaze(x - 1, y, step + 1, path + "W");

            if (_solverField[x, y].CanGoSouth())
                SolveMaze(x, y+1, step + 1, path + "S");
        }
    }
}