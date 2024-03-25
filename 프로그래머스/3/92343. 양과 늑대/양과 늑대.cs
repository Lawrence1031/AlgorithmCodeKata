using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] info, int[,] edges) {
        int answer = 0;

        var visited = new HashSet<int>();
        visited.Add(0);

        DFS(1, 0, visited, info, edges, ref answer);
        
        return answer;        
    }
    private static void DFS(int sheepCount, int wolfCount, HashSet<int> visited, 
                            int[] info, int[,] edges, ref int answer)
    {
        if (sheepCount <= wolfCount)
        {
            return;
        }

        answer = Math.Max(answer, sheepCount);

        for (int i = 0; i < edges.GetLength(0); i++)
        {
            int parent = edges[i, 0];
            int child = edges[i, 1];

            if (visited.Contains(parent) && !visited.Contains(child))
            {
                visited.Add(child);

                if (info[child] == 0)
                {
                    DFS(sheepCount + 1, wolfCount, visited, info, edges, ref answer);
                }
                else
                {
                    DFS(sheepCount, wolfCount + 1, visited, info, edges, ref answer);
                }
                visited.Remove(child);
            }
        }
    }
}
