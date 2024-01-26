using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        
        int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == 1)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        int newX = i + dx[k];
                        int newY = j + dy[k];

                        if (newX >= 0 && newX < board.GetLength(0) && 
                            newY >= 0 && newY < board.GetLength(1))
                        {
                            if (board[newX, newY] == 0)
                                board[newX, newY] = 2;
                        }
                    }
                }
            }
        }

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == 0)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}