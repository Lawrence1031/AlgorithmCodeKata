using System;

public class Solution {
    public int solution(string name) {
        int answer = 0;
        
        for (int i = 0; i < name.Length; i++)
        {
            int count = Math.Min(name[i] - 'A', 'Z' - name[i] + 1);
            answer += count;
        }

        int minMove = name.Length - 1;
        for (int i = 0; i < name.Length; i++)
        {
            int next = i + 1;

            while (next < name.Length && name[next] == 'A')
            {
                next++;
            }

            int move = Math.Min(i, name.Length - next);
            int tmpMove = i + name.Length - next + move;
            minMove = Math.Min(minMove, tmpMove);
        }

        answer += minMove;
        
        return answer;
    }
}