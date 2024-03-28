using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 1;
        
        for (int i = 0; i < after.Length; i++)
        {
            for (int j = 0; j < before.Length; j++)
            {
                if (after[i] == before[j])
                {
                    before = before.Remove(j, 1);
                    break;
                }
            }
        }

        if (before.Length > 0)
            answer = 0;
        
        return answer;
    }
}