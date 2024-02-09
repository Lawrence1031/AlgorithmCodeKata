using System;
using System.Collections.Generic;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[,] {{}};
        
        answer = Solve.Hanoi(n);
        return answer;
    }
}

public class Solve
{
    public static int[,] Hanoi(int n)
    {
        var moveList = new List<List<int>>();
        Hanoi(n, 1, 3, 2, moveList);

        int[,] moveArray = new int[moveList.Count, 2];

        for (int i = 0; i < moveList.Count; i++)
        {
            moveArray[i, 0] = moveList[i][0];
            moveArray[i, 1] = moveList[i][1];
        }

        return moveArray;
    }
    static public void Hanoi(int n, int from, int to, int aux, List<List<int>> result)
    {
        if (n == 0)
        {
            return;
        }

        Hanoi(n - 1, from, aux, to, result);
        result.Add(new List<int> { from, to });
        Hanoi(n - 1, aux, to, from, result);
    }
}