namespace AlgorimsFindPath.SearchPath.Neighbor
{
    public interface INeighbor
    {
        public List<Point> getNeighbor(int[,] map, int x, int y);
    }
}
