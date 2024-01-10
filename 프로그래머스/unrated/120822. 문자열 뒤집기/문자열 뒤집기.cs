using System;

public class Solution {
    public string solution(string my_string) {
        
        char[] myChar = my_string.ToCharArray();
        Array.Reverse(myChar);
        string answer = new string(myChar);
        
        return answer;
    }
}