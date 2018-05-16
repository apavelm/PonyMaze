using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoneMaze.MazeSolver;
using PonyMaze.Common;
using RestApiClient;
using RestApiClient.Exceptions;

namespace PonyMaze
{
    public partial class MainForm : Form
    {
        private PonyApiClient _client = null;
        private Guid _mazeId = Guid.Empty;
        private MazeSolver _solver = null;

        public MainForm()
        {
            InitializeComponent();

            m_Init();
        }

        private void m_Init()
        {
            _client = new PonyApiClient();
        }

        private void DoLog(string text)
        {
            txtLog.Text += text + Environment.NewLine;
        }

        private async void btnCreateMaze_Click(object sender, EventArgs e)
        {
            var w = (int)edtMazeWidth.Value;
            var h = (int)edtMazeHeight.Value;
            var d = (int)edtDifficulty.Value;
            var name = edtPlayerName.Text;

            try
            {
                _mazeId = await _client.CreateMaze(w, h, name, d);
            }
            catch (PonyClientException ex)
            {
                DoLog(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                DoLog("CRITICAL: " + ex.Message);
                return;
            }

            edtMazeId.Text = _mazeId.ToString();
            txtSequence.Text = "";
            DoLog("Maze created, id = " + _mazeId);
            DoLog($"Size: {w}x{h}, Difficulty: {d}");

            await UpdateMazeState();
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await _client.GetPrintedMaze(_mazeId);
                DoLog(response);
            }
            catch (PonyClientException ex)
            {
                DoLog(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                DoLog("CRITICAL: " + ex.Message);
                return;
            }
        }

        private async void btnLoadMaze_Click(object sender, EventArgs e)
        {
            txtSequence.Text = "";
            if (!Guid.TryParse(edtMazeId.Text, out _mazeId))
            {
                edtMazeId.Text = "";
                DoLog("Error: Maze ID guid is not valid.");
            }

            // load
            try
            {
                var state = await _client.GetMazeCurrentState(_mazeId);
                _solver = MazeSolver.Load(state);
                DoLog($"Maze with ID = {_mazeId} loaded.");
                DoLog("Maze State: " + state.State);
                DoLog("Maze Result State: " + state.MazeStateResult);
                if (!string.IsNullOrEmpty(state.HiddenImageUrl))
                {
                    DoLog("Hidden Image Url: " + state.HiddenImageUrl);
                }

                await UpdateMazeState(state);
            }
            catch (PonyClientException ex)
            {
                DoLog(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                DoLog("CRITICAL: " + ex.Message);
                return;
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            var solutions = _solver.Solve();
            if (!solutions.Any())
            {
                DoLog("No Solutions found!");
                return;
            }

            DoLog("Maze solved: " + solutions.Count + " ways found.");
            var i = 1;
            foreach (var s in solutions)
            {
                DoLog(i++ + ": " + s);
            }
        }

        private async Task DoMove(Direction direction)
        {
            try
            {
                var response = await _client.MakeMove(_mazeId, direction);
                DoLog($"Move {direction}. State: {response.State}, Result: {response.Result}");
                if (!string.IsNullOrEmpty(response.ImageUrl))
                {
                    try
                    {
                        var imgData = await _client.LoadImage(response.ImageUrl);
                        var ms = new MemoryStream(imgData);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    catch (Exception ex)
                    {
                        DoLog(ex.Message);
                    }
                }
            }
            catch (PonyClientException ex)
            {
                DoLog(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                DoLog("CRITICAL: " + ex.Message);
                return;
            }
        }

        private async Task<bool> UpdateMazeState(MazeState state = null)
        {
            var waitBmp = MazePainter.MazePainter.GetWaitBmp();
            pictureBox1.Image = waitBmp;

            if (state == null)
            {
                try
                {
                    state = await _client.GetMazeCurrentState(_mazeId);
                }
                catch (PonyClientException ex)
                {
                    DoLog(ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    DoLog("CRITICAL: " + ex.Message);
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(state.HiddenImageUrl))
            {
                try
                {
                    var imgData = await _client.LoadImage(state.HiddenImageUrl);
                    var ms = new MemoryStream(imgData);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    DoLog(ex.Message);
                }
            }
            else
            {
                _solver = MazeSolver.Load(state);
                // paint a maze
                var bmp = MazePainter.MazePainter.RepresentMaze(_solver.Field,
                    state.MazeWidth, state.MazeHeight,
                    _solver.PonyLocation.x, _solver.PonyLocation.y,
                    _solver.ExitLocation.x, _solver.ExitLocation.y,
                    _solver.DomokunLocation.x, _solver.DomokunLocation.y);
                pictureBox1.Image = bmp;
            }

            if (state.State == "over" || state.State == "won") return false;
            return true;
        }

        private async void btnUp_Click(object sender, EventArgs e)
        {
            await DoMove(Direction.North);
            await UpdateMazeState();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await DoMove(Direction.East);
            await UpdateMazeState();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await DoMove(Direction.South);
            await UpdateMazeState();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await DoMove(Direction.West);
            await UpdateMazeState();
        }

        private async void btnGO_Click(object sender, EventArgs e)
        {
            var solutionString = txtSequence.Text;

            var stop = false;
            foreach (var s in solutionString)
            {
                switch (s)
                {
                    case 'N':
                        await DoMove(Direction.North);
                        if (!await UpdateMazeState()) stop = true;
                        await Task.Delay(1500);
                        break;
                    case 'S':
                        await DoMove(Direction.South);
                        if (!await UpdateMazeState()) stop = true;
                        await Task.Delay(1500);
                        break;
                    case 'E':
                        await DoMove(Direction.East);
                        if (!await UpdateMazeState()) stop = true;
                        await Task.Delay(1500);
                        break;
                    case 'W':
                        await DoMove(Direction.West);
                        if (!await UpdateMazeState()) stop = true;
                        await Task.Delay(1500);
                        break;
                    default:
                        continue;
                }

                if (stop) break;
            }
        }
    }
}
