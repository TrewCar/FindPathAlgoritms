using AlgorimsFindPath.SearchPath.Neighbor;

namespace AlgorimsFindPath.SearchPath
{
    public class AStar : FindPath
    {
		// Приоритетная очередь для хранения узлов для проверки
		private PriorityQueue<(Point point, float priority), float> openSet;
		// Словарь для хранения стоимости пути от начальной точки до текущей
		private Dictionary<Point, float> gScore;
		// Словарь для хранения эвристической стоимости пути от текущей точки до конечной
		private Dictionary<Point, float> fScore;

		public AStar(int[,] map, Point startPos, Point endPos, INeighbor neighbor)
			: base(map, startPos, endPos, neighbor)
		{
			openSet = new PriorityQueue<(Point point, float priority), float>();
			gScore = new Dictionary<Point, float>();
			fScore = new Dictionary<Point, float>();

			// Начальная точка имеет стоимость 0
			gScore[startPos] = 0;
			// Эвристическая оценка для начальной точки
			fScore[startPos] = calcDisc(startPos, endPos);

			// Добавляем начальную точку в очередь
			openSet.Enqueue((startPos, fScore[startPos]), fScore[startPos]);
		}

		public override bool Step()
		{
			if (openSet.Count == 0)
			{
				return true; // Path not found
			}

			var current = openSet.Dequeue().point;
			now = current;

			if (current.Equals(endPos))
			{
				return true; // Path found
			}

			already.Add(current);

			foreach (var neighbor in getNeighbor(current.X, current.Y))
			{
				if (already.Contains(neighbor))
				{
					continue;
				}

				// Вычисляем стоимость пути до соседа
				float tentativeGScore = gScore[current] + calcDisc(current, neighbor);

				// Если найден более короткий путь до соседа или сосед не был проверен
				if (!gScore.ContainsKey(neighbor) || tentativeGScore < gScore[neighbor])
				{
					// Обновляем путь и стоимости
					Path[neighbor] = current;
					gScore[neighbor] = tentativeGScore;
					fScore[neighbor] = gScore[neighbor] + calcDisc(neighbor, endPos);

					// Добавляем соседа в очередь, если он еще не в ней
					if (!openSet.UnorderedItems.Any(item => item.Element.point.Equals(neighbor)))
					{
						openSet.Enqueue((neighbor, fScore[neighbor]), fScore[neighbor]);
					}
				}
			}

			// Продолжаем поиск
			return false;
		}
	}
}
