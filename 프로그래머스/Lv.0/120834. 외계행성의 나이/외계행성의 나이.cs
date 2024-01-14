using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        
        for (int i = 0; i < age.ToString().Length; i++)
        {
            answer += AgeChar(age.ToString()[i]);
        }
        
        return answer;
    }
    
    static char AgeChar(int n)
    {
        return (char)('a' + (n - '0'));
    }
}