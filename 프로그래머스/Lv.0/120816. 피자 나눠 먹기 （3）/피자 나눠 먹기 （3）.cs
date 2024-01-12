using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
        double num = (double)n / slice;
        double result = Math.Ceiling(num);
        
        answer = (int)Math.Ceiling((double)num);
        
        return answer;
    }
}