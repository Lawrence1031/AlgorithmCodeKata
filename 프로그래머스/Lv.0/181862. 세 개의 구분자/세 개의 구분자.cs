using System;

public class Solution {
    public string[] solution(string myStr) {
        
        char[] splitChars = {'a', 'b', 'c'};
        
        string[] answer = myStr.Split(splitChars, System.StringSplitOptions.RemoveEmptyEntries);
        
        return answer.Length == 0 ? new string[1]{ "EMPTY" } : answer; 
    }
}