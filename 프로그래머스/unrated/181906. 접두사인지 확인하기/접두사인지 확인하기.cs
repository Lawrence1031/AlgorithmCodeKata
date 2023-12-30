using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        
        if (my_string.StartsWith(is_prefix))
            answer = 1;
        
        return answer;
    }
}