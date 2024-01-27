using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        
        int tmp = 0;
        Array.Sort(d);
        
        for (int i = 0; i < d.Length; i++)
        {
            tmp += d[i];
            answer++;
            if (tmp > budget)
            {
                answer--;
                break;
            }
        }
        
        return answer;
    }
}