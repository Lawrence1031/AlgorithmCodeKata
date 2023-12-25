using System;

public class Solution {
    public int solution(double flo) {
        int answer = 0;
        
        double result = Math.Truncate(flo);
        answer = Convert.ToInt32(result);
        
        return answer;
    }
}