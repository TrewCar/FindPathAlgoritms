using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorimsFindPath.SearchPath.Neighbor
{
    internal class _8Neighbor : INeighbor
    {
        public List<Point> getNeighbor(int[,] map, int x, int y)
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
