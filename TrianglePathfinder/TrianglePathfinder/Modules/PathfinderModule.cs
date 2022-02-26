using System.Collections.Generic;
using System.Linq;

namespace TrianglePathfinder.Modules
{
    internal class PathfinderModule
    {
        private static int GetIndex(int[] dist, bool[] set, int vCount)
        {
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < vCount; ++i)
                if (set[i] == false && dist[i] > max)
                {
                    max = dist[i];
                    index = i;
                }
            return index;
        }
        public static string[] Dijkstra(int[,] graph)
        {
            int count = graph.GetLength(0);
            string[] path = new string[count + 1];
            string[] pathMax = new string[count + 1];
            int[] dist = new int[count];
            bool[] set = new bool[count];
            for (int i = 0; i < count; ++i)
            {
                dist[i] = int.MinValue;
                set[i] = false;
            }
            dist[0] = graph[0, 0];
            for (int i = 0; i < count - 1; ++i)
            {
                int n = GetIndex(dist, set, count);
                set[n] = true;
                for (int j = 0; j < count; ++j)
                    if (!set[j] && graph[n, j] != 0 && dist[n] != int.MinValue && dist[n] + graph[n, j] > dist[j])
                    {
                        dist[j] = dist[n] + graph[n, j];
                        path[j] = ($"{n + 1}-{j + 1} = {dist[j]}");
                        pathMax[j] = $"{n + 1}-{j + 1}";
                    }
            }
            List<int> indexes = new List<int>();
            int max = dist.Max();
            for (int i = 0; i < dist.Length; i++)
                if (max == dist[i])
                    indexes.Add(i);
            string outMaxPath = pathMax[indexes[0]];
            for (int i = pathMax.Length - 2; i >= 1; i--)
                if (outMaxPath.Split('-')[0] == pathMax[i].Split('-')[1])
                    outMaxPath = (pathMax[i].Split('-')[0] + "-" + outMaxPath);
            path[count] = $"\nМаксимальная сумма: \n{outMaxPath} = {max}";
            return path;
        }
    }
}
