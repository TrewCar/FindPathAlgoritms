using AlgorimsFindPath.SearchPath.Neighbor;

namespace AlgorimsFindPath.SearchPath
{
    public class AStar : FindPath
    {
        public AStar(int[,] map, Point startPos, Point endPos, INeighbor neighbor) : base(map, startPos, endPos, neighbor)
        {
            queue.Add((0, startPos));
        }
        /// <summary>
        /// Очередь с сортировки по ключу dist
        /// </summary>
        protected SortedSet<(float dist, Point crd)> queue 
            = new SortedSet<(float dist, Point crd)>(Comparer<(float dist, Point crd)>.Create((a, b) =>
        {
            int result = a.dist.CompareTo(b.dist);
            return result == 0 ? a.crd.GetHashCode().CompareTo(b.crd.GetHashCode()) : result;
        }));

        public override bool Step()
        {
            if (queue.Count == 0)
            {
                return true; // No path found
            }

            now = queue.Min.Item2;
            queue.Remove(queue.Min);

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

                float distance = calcDisc(endPos, neighbor) + calcDisc(startPos, neighbor); // f = g + h
                queue.Add((distance, neighbor));
                if (!Path.ContainsKey(neighbor))
                {
                    Path[neighbor] = now;
                }
            }

            return false;
        }
    }
}
