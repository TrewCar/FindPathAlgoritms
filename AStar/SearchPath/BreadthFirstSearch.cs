using AlgorimsFindPath.SearchPath.Neighbor;
namespace AlgorimsFindPath.SearchPath
{
    public class BreadthFirstSearch : FindPath
    {
        private Queue<Point> queue = new Queue<Point>();

        public BreadthFirstSearch(int[,] map, Point startPos, Point endPos, INeighbor neighbor) : base(map, startPos, endPos, neighbor)
        {
            queue.Enqueue(startPos);
        }

        public override bool Step()
        {
            if (queue.Count == 0)
            {
                return true; // No path found
            }

            now = queue.Dequeue();

            if (now.Equals(endPos))
            {
                return true; // Path found
            }

            already.Add(now);

            var neighbors = getNeighbor(now.X, now.Y);
            foreach (Point neighbor in neighbors)
            {
                if (already.Contains(neighbor))
                    continue;

                queue.Enqueue(neighbor);
                Path[neighbor] = now;
            }

            return false;
        }

        protected override List<Point> getNeighbor(int x, int y)
        {
            var result = new List<Point>();

            for (var i = x - 1; i <= x + 1; i++)
            {
                for (var j = y - 1; j <= y + 1; j++)
                {
                    if (i == x && j == y ||
                        i < 0 || j < 0 ||
                        i >= map.GetLength(0) || j >= map.GetLength(1))
                        continue;

                    if (map[i, j] == 1)
                        continue;

                    result.Add(new Point(i, j));
                }
            }

            return result;
        }
    }
}