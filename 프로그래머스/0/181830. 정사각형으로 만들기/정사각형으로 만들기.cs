using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int col = arr.GetLength(0);
        int row = arr.GetLength(1);

        while (col != row)
        {
            if (col > row)
                row++;
            else
                col++;
        }

        int[,] answer = new int[col, row];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0;  j < arr.GetLength(1); j++)
            {
                answer[i, j] = arr[i, j];
            }
        }
        
        return answer;
    }
}