using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        char[] numChar = num_str.ToCharArray();
        
        for (int i = 0; i < numChar.Length; i++)
        {
            answer += numChar[i] - '0';
        }
        
        return answer;
    }
}