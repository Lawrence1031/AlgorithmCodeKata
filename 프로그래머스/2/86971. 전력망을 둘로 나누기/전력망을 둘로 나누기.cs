using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[,] wires) {
        int answer = n;

        for (int i = 0; i < n - 1; i++)
        {
            List<List<int>> graph = new List<List<int>>();
            for (int j = 0; j <= n; j++)
            {
                graph.Add(new List<int>());
            }

            for (int j = 0; j < n - 1; j++)
            {
                if (i == j)
                {
                    continue;
                }
                int a = wires[j, 0];
                int b = wires[j, 1];
                graph[a].Add(b);
                graph[b].Add(a);
            }

            bool[] visited = new bool[n + 1];
            int count = DFS(1, graph, visited);

            answer = Math.Min(answer, Math.Abs(count - (n - count)));

        }
        return answer;
    }
    static int DFS(int node, List<List<int>> graph, bool[] visited)
    {
        visited[node] = true;
        int count = 1;

        foreach (var next in graph[node])
        {
            if (!visited[next])
            {
                count += DFS(next, graph, visited);
            }
        }

        return count;
    }
}