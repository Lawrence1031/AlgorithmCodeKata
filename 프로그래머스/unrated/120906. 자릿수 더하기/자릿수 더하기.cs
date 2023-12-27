using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for (int i = 0; i < n.ToString().Length; i++)
        answer += n.ToString()[i] - '0';
        
        return answer;
    }
}