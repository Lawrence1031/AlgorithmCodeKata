using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int tmp;
        
        char[] myChar = my_string.ToCharArray();
        
        for (int i = 0; i < myChar.Length; i++)
        {
            if (int.TryParse(myChar[i].ToString(), out tmp))
            {
                answer += tmp;                
            }
        }
        
        
        
        return answer;
    }
}