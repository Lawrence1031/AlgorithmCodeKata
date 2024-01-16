using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        
        int lastIndex = myString.LastIndexOf(pat);
        answer = myString.Substring(0, lastIndex + pat.Length);
        
        return answer;
    }
}