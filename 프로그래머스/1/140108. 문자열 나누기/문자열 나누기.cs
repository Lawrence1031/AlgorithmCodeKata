using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        int cnt1 = 0; 
        int cnt2 = 0;
        char[] chars = s.ToCharArray();
        char currentChar = chars[0];

        for (int i = 0; i < chars.Length; i++)
        {

            if (chars[i] == currentChar)
            {
                cnt1++;
            }
            else if (chars[i] != currentChar)
            {
                cnt2++;
            }

            if(cnt1 == cnt2)
            {
                answer++;
                if ( i < chars.Length - 1 )
                {
                    currentChar = chars[i + 1];
                }
            }
            
            if (i == chars.Length - 1 && cnt1 != cnt2)
                answer++;
        }
            
        return answer;
    }
}