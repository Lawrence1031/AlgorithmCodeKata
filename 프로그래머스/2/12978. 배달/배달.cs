using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int N, int[,] road, int K)
    {
        int answer = 0;
        const int maxDistance = 5000001;

        var graph = new Dictionary<int, List<Tuple<int, int>>>();
        var distances = new Dictionary<int, int>();

        for (int i = 1; i <= N; i++)
        {
            graph[i] = new List<Tuple<int, int>>();
            distances[i] = maxDistance;
        }

        for (int i = 0; i < road.GetLength(0); i++)
        {
            int a = road[i, 0];
            int b = road[i, 1];
            int l = road[i, 2];
            graph[a].Add(new Tuple<int, int>(b, l));
            graph[b].Add(new Tuple<int, int>(a, l));
        }

        var DijkstraQueue = new SortedSet<Tuple<int, int>>();
        DijkstraQueue.Add(new Tuple<int, int>(0, 1));
        distances[1] = 0;

        while (DijkstraQueue.Count > 0)
        {
            var cur = DijkstraQueue.Min;
            DijkstraQueue.Remove(cur);

            int curDistance = cur.Item1;
            int curNode = cur.Item2;

            if (distances[curNode] < curDistance)
            {
                continue;
            }

            foreach (var edge in graph[curNode])
            {
                int nextNode = edge.Item1;
                int weight = edge.Item2;
                int nextDistance = curDistance + weight;

                if (nextDistance < distances[nextNode])
                {
                    distances[nextNode] = nextDistance;
                    DijkstraQueue.Add(new Tuple<int, int>(nextDistance, nextNode));
                }
            }
        }

        foreach (var distance in distances)
        {
            if (distance.Value <= K)
                answer++;
        }

        return answer;
    }
}