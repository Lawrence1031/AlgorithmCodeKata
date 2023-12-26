using System;

public class Solution {
    public int solution(int[] num_list, int n) {
        int answer = 0;
        
        int idx = Array.IndexOf(num_list, n);
        if (idx > -1)
            answer = 1;
        
        return answer;
    }
}