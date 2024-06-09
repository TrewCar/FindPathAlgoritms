using AlgorimsFindPath.SearchPath.Neighbor;

namespace AlgorimsFindPath.SearchPath
{
    public abstract class FindPath
    {
        public FindPath(int[,] map, Point startPos, Point endPos, INeighbor neighbor)
        {
            this.map = map;
            this.startPos = startPos;
            this.endPos = endPos;
            this.neighbor = neighbor;

            now = startPos;

            Path[startPos] = startPos;
        }
        private INeighbor neighbor;

        protected int[,] map;
        protected Point startPos;
        protected Point endPos;
        protected Point now;


        protected Dictionary<Point, Point> Path = new Dictionary<Point, Point>();
        protected HashSet<Point> already = new HashSet<Point>();

        public abstract bool Step();
        protected List<Point> getNeighbor(int x, int y)
        {
            return neighbor.getNeighbor(map, x, y);
        }

        public void Process()
        {
            while (!Step()) ;
        }

        public virtual List<Point> GetPath()
        {
            var result = new List<Point>();
            if (!Path.ContainsKey(now))
            {
                return result; // Path not found
            }

            var currentPos = now;
            while (!currentPos.Equals(startPos)) // Продолжаем пока не вернемся к стартовой точке
            {
                result.Add(currentPos);
                currentPos = Path[currentPos];
            }
            result.Add(startPos); // Добавляем стартовую точку в путь
            result.Reverse();
            return result;
        }
        protected float calcDisc(Point pos1, Point pos2)
            => MathF.Sqrt(MathF.Pow(pos1.X - pos2.X, 2) + MathF.Pow(pos1.Y - pos2.Y, 2));
    }
}
