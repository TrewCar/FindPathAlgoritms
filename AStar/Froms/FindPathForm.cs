using AlgorimsFindPath.Options;
using AlgorimsFindPath.SearchPath;
using System.Windows.Forms;

namespace AlgorimsFindPath.Froms
{
    public partial class FindPathForm: Form
    {
        public FindPathForm(Func<int[,], Point, Point, FindPath> createPathFinder, string Title, bool blockByStep = false)
        {
            InitializeComponent();
            this.Text = Title;
            byStep.Enabled = !blockByStep;
            this.createPathFinder = createPathFinder;
            pictureMap.Image = new Bitmap(pictureMap.Width, pictureMap.Height);
            g = Graphics.FromImage(pictureMap.Image);
            Clear_Click(null, null);
        }

        private Func<int[,], Point, Point, FindPath> createPathFinder;

        private Graphics g;
        private int _sizeCell = 10;
        private int[,] map;
        private Point startPos, endPos;
        private FindPath? aStar;
        private bool IsDraw = false;
        private bool IsStart = false;

        private void InitializeMap()
        {
            int countCell = pictureMap.Width / _sizeCell;
            map = new int[countCell, countCell];
            startPos = new Point(0, 0);
            endPos = new Point(countCell - 1, countCell - 1);
        }

        private void startAction_Click(object sender, EventArgs e)
        {
            if (IsStart)
            {
                timer1.Start();
                return;
            }
            ReplaceTwosWithZeros();
            DrawMap();
            aStar = createPathFinder(map, startPos, endPos);
            if (byStep.Checked)
            {
                timer1.Start();
                SetStateStartButton();
            }
            else
            {
                aStar.Process();
                Tick();
                aStar = null;
            }
        }

        private void ReplaceTwosWithZeros()
        {
            for (int i = 0; i < map.GetLength(0); i++)
                for (int j = 0; j < map.GetLength(1); j++)
                    if (map[i, j] == 2) map[i, j] = 0;
        }

        private void Tick()
        {
            var items = aStar.GetPath();
            for (int i = 0; i < items.Count; i++)
            {
                if(i == items.Count-1)
                    DrawCell(items[i].X, items[i].Y, Colors.HeadPath);
                else
                    DrawCell(items[i].X, items[i].Y, Colors.Path);
                map[items[i].X, items[i].Y] = 2;
            }
            DrawStartEndPoint();
            pictureMap.Invalidate();
        }

        private void DrawMap()
        {
            for (int x = 0; x < map.GetLength(0); x++)
                for (int y = 0; y < map.GetLength(1); y++)
                    DrawCell(x, y, map[x, y] == 0 ? Colors.Floor : map[x, y] == 1 ? Colors.Wall : Colors.AlreadyPath);

            pictureMap.Invalidate();
        }

        private void DrawStartEndPoint()
        {
            DrawCell(startPos.X, startPos.Y, Colors.StartPos);
            DrawCell(endPos.X, endPos.Y, Colors.EndPos);
        }

        private void DrawCell(int x, int y, Brush color)
            => g.FillRectangle(color, x * _sizeCell, y * _sizeCell, _sizeCell, _sizeCell);

        private void Clear_Click(object sender, EventArgs e)
        {
            InitializeMap();
            DrawMap();
            DrawStartEndPoint();
        }

        private void pictureMap_MouseDown(object sender, MouseEventArgs e) => IsDraw = true;

        private void pictureMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsStart) return;
            if (!IsDraw) return;

            Point mousePos = new Point(e.X / _sizeCell, e.Y / _sizeCell);
            if (mousePos.X < 0 || mousePos.X >= map.GetLength(0) || mousePos.Y < 0 || mousePos.Y >= map.GetLength(1)) return;
            if (mousePos == startPos || mousePos == endPos) return;

            map[mousePos.X, mousePos.Y] = drawMod.Checked ? 1 : 0;
            DrawCell(mousePos.X, mousePos.Y, drawMod.Checked ? Colors.Wall : Colors.Floor);
            pictureMap.Invalidate();
        }

        private void pictureMap_MouseUp(object sender, MouseEventArgs e) => IsDraw = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aStar.Step())
            {
                timer1.Stop();
				DrawMap();
				DrawStartEndPoint();
				Tick();
				aStar = null;
                SetStateStartButton();
                return;
            }
            DrawMap();
            DrawStartEndPoint();
            Tick();
        }

        private void SetPosition(Action<Point> setPosAction)
        {
            if (IsStart)
                return;

            SetPoint form = new SetPoint(map.GetLength(0) - 1, map.GetLength(1) - 1);
            form.ShowDialog();
            if (form.Result.X == -1 || form.Result.Y == -1) return;

            setPosAction(form.Result);
            DrawMap();
            DrawStartEndPoint();
        }

        private void setStartPos_Click(object sender, EventArgs e) => SetPosition(pos => startPos = pos);

        private void setEndPos_Click(object sender, EventArgs e) => SetPosition(pos => endPos = pos);

        private void setDefault_Click(object sender, EventArgs e)
        {
            if (IsStart)
                return;

            startPos = new Point(0, 0);
            endPos = new Point(map.GetLength(0) - 1, map.GetLength(1) - 1);
            Clear_Click(null, null);
        }

        private void stopAction_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void SetStateStartButton()
        {
            IsStart = !IsStart;
            startAction.Text = IsStart ? "Continue" : "Start";
        }

        private void disposeAction_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            IsStart = true;
            SetStateStartButton();
            aStar = null;
            ReplaceTwosWithZeros();
            DrawMap();
            DrawStartEndPoint();
        }
    }
}
