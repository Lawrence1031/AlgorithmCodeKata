using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        
        foreach (string choice in order)
        {
            answer += choice.Contains('n') ? 4500 : 5000;
        }        
        
        return answer;
    }
}