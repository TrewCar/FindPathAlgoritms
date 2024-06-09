using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorimsFindPath.SearchPath.Neighbor
{
    internal class _4Neighbor : INeighbor
    {
        public List<Point> getNeighbor(int[,] map, int x, int y)
        {
            var result = new List<Point>();

            // Check neighbor up
            if (y - 1 >= 0 && map[x, y - 1] != 1)
                result.Add(new Point(x, y - 1));

            // Check neighbor down
            if (y + 1 < map.GetLength(1) && map[x, y + 1] != 1)
                result.Add(new Point(x, y + 1));

            // Check neighbor left
            if (x - 1 >= 0 && map[x - 1, y] != 1)
                result.Add(new Point(x - 1, y));

            // Check neighbor right
            if (x + 1 < map.GetLength(0) && map[x + 1, y] != 1)
                result.Add(new Point(x + 1, y));

            return result;
        }
    }
}
