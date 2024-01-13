using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        
        char[] newChar = my_string.ToCharArray();
        
        for (int i = 0; i < newChar.Length; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer += newChar[i];
            }
        }
        
        return answer;
    }
}