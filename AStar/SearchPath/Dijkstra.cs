using AlgorimsFindPath.SearchPath.Neighbor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorimsFindPath.SearchPath
{
    public class Dijkstra : FindPath
    {
        private SortedSet<(float, Point)> priorityQueue = new SortedSet<(float, Point)>(Comparer<(float, Point)>.Create((a, b) =>
        {
            int result = a.Item1.CompareTo(b.Item1);
            return result == 0 ? a.Item2.GetHashCode().CompareTo(b.Item2.GetHashCode()) : result;
        }));

        public Dijkstra(int[,] map, Point startPos, Point endPos, INeighbor neighbor) : base(map, startPos, endPos,neighbor)
        {
            priorityQueue.Add((0, startPos));
        }

        public override bool Step()
        {
            if (priorityQueue.Count == 0)
            {
                return true; // No path found
            }

            now = priorityQueue.Min.Item2;
            priorityQueue.Remove(priorityQueue.Min);

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

                float distance = calcDisc(now, neighbor); // d(u, v)
                float newDistance = distance + calcDisc(neighbor, endPos); // d(u, v) + h(v)
                priorityQueue.Add((newDistance, neighbor));
                if (!Path.ContainsKey(neighbor))
                {
                    Path[neighbor] = now;
                }
            }

            return false;
        }
    }
}
