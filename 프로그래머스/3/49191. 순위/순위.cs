using System;

public class Solution {
    public int solution(int n, int[,] results) {
        int answer = 0;
        
        bool[,] winGraph = new bool[n, n];

        for (int i = 0; i < results.GetLength(0); i++)
        {
            int win = results[i, 0] - 1;
            int lose = results[i, 1] - 1;
            winGraph[win, lose] = true;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (winGraph[j, i] && winGraph[i, k])
                    {
                        winGraph[j, k] = true;
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (winGraph[i, j] || winGraph[j, i])
                {
                    count++;
                }
            }

            if (count == n - 1)
            {
                answer++;
            }
        }
        return answer;
    }
}