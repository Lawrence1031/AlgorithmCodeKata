using System;



public class Solution {
    private int[] board;
    private int answer;
    private int size;
    
    public int solution(int n) {
        answer = 0;
        size = n;
        board = new int[n];
        SolveNQueen(0);      
        return answer;
    }
    public bool IsSafe(int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            if (board[i] == col || Math.Abs(board[i] - col) == Math.Abs(i - row))
            {
                return false;
            }
        }
        return true;
    }

    public void SolveNQueen(int row)
    {
        if (row == size)
        {
            answer++;
            return;
        }

        for (int col = 0; col < size; col++)
        {
            if (IsSafe(row, col))
            {
                board[row] = col;
                SolveNQueen(row + 1);
            }
        }
    }
    
}