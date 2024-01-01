using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int answer = 0;
        
        if (my_string[my_string.Length - 1] == is_suffix[is_suffix.Length - 1])
        {
            if (my_string.Contains(is_suffix))
                answer = 1;
        }
        
        return answer;
    }
}