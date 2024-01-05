using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        
        char[] numChar = number.ToCharArray();
        
        int num = 0;
        
        for (int i = 0; i < numChar.Length; i++)
        {
            num += numChar[i] - '0';
        }
        
        answer = num % 9;
        
        return answer;
    }
}