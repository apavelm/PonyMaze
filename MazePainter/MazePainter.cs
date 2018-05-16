using System.Drawing;
using PonyMaze.Common;

namespace MazePainter
{
    public static class MazePainter
    {
        public static Bitmap GetWaitBmp()
        {
            var bmp = new Bitmap(Constants.PAINTER_CELL_SIZE * 20, Constants.PAINTER_CELL_SIZE * 15);
            using (var g = Graphics.FromImage(bmp))
            {
                g.DrawString("Please wait...", new Font("Arial", 12), new SolidBrush(Color.Black), Constants.PAINTER_CELL_SIZE, Constants.PAINTER_CELL_SIZE * 5);
            }
            return bmp;
        }

        public static Bitmap RepresentMaze(MazeCell[,] field, 
                int width, int height, 
                int pony_x, int pony_y,
                int exit_x, int exit_y, 
                int domokun_x, int domokun_y)
        {
            var bmp = new Bitmap(Constants.PAINTER_CELL_SIZE * width, Constants.PAINTER_CELL_SIZE * height);
            var wallPen = new Pen(Color.Black, 2);

            var ponyPen = new Pen(Color.DodgerBlue, 2);
            var monsterPen = new Pen(Color.DarkRed, 2);
            var exitPen = new Pen(Color.LimeGreen, 2);


            using (var g = Graphics.FromImage(bmp))
            {
                for (var x = 0; x < width; x++)
                for (var y = 0; y < height; y++)
                {
                    var cell = field[x, y];

                    if (cell.HasFlag(MazeCell.North))
                        g.DrawLine(wallPen, x * Constants.PAINTER_CELL_SIZE, y * Constants.PAINTER_CELL_SIZE,
                            (x + 1) * Constants.PAINTER_CELL_SIZE, y * Constants.PAINTER_CELL_SIZE);

                    if (cell.HasFlag(MazeCell.South))
                        g.DrawLine(wallPen, x * Constants.PAINTER_CELL_SIZE, (y + 1) * Constants.PAINTER_CELL_SIZE,
                            (x + 1) * Constants.PAINTER_CELL_SIZE, (y + 1) * Constants.PAINTER_CELL_SIZE);

                    if (cell.HasFlag(MazeCell.West))
                        g.DrawLine(wallPen, x * Constants.PAINTER_CELL_SIZE, y * Constants.PAINTER_CELL_SIZE,
                            x * Constants.PAINTER_CELL_SIZE, (y + 1) * Constants.PAINTER_CELL_SIZE);

                    if (cell.HasFlag(MazeCell.East))
                        g.DrawLine(wallPen, (x + 1) * Constants.PAINTER_CELL_SIZE, y * Constants.PAINTER_CELL_SIZE,
                            (x + 1) * Constants.PAINTER_CELL_SIZE, (y + 1) * Constants.PAINTER_CELL_SIZE);
                }

                g.DrawLine(wallPen, 0, height * Constants.PAINTER_CELL_SIZE, width * Constants.PAINTER_CELL_SIZE,
                    height * Constants.PAINTER_CELL_SIZE);
                g.DrawLine(wallPen, width * Constants.PAINTER_CELL_SIZE, 0, width * Constants.PAINTER_CELL_SIZE,
                    height * Constants.PAINTER_CELL_SIZE);

                g.DrawEllipse(ponyPen, pony_x * Constants.PAINTER_CELL_SIZE + Constants.PAINTER_CELL_SIZE / 4,
                    pony_y * Constants.PAINTER_CELL_SIZE + Constants.PAINTER_CELL_SIZE / 4,
                    Constants.PAINTER_CELL_SIZE / 2, Constants.PAINTER_CELL_SIZE / 2);
                g.DrawEllipse(monsterPen, domokun_x * Constants.PAINTER_CELL_SIZE + Constants.PAINTER_CELL_SIZE / 4,
                    domokun_y * Constants.PAINTER_CELL_SIZE + Constants.PAINTER_CELL_SIZE / 4,
                    Constants.PAINTER_CELL_SIZE / 2, Constants.PAINTER_CELL_SIZE / 2);
                g.DrawEllipse(exitPen, exit_x * Constants.PAINTER_CELL_SIZE + Constants.PAINTER_CELL_SIZE / 4,
                    exit_y * Constants.PAINTER_CELL_SIZE + Constants.PAINTER_CELL_SIZE / 4,
                    Constants.PAINTER_CELL_SIZE / 2, Constants.PAINTER_CELL_SIZE / 2);
            }

            return bmp;
        }
    }
}