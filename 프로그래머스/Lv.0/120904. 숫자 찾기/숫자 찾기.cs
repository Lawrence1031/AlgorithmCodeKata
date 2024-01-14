using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = -1;
        
        char[] numChar = num.ToString().ToCharArray();
        char kChar = k.ToString()[0];
            
        for (int i = 0; i < numChar.Length; i++)
        {
            if (numChar[i] == kChar)
            {
                answer = i + 1;
                break;
            }
        }
        
        return answer;
    }
}