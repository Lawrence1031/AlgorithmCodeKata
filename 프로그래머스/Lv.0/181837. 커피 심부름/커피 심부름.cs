using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        
        for (int i = 0; i < order.Length; i++)
        {
            if (order[i].Contains('n'))
                answer += 4500;
            else
                answer += 5000;
        }
        
        
        return answer;
    }
}