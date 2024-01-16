using System;

public class Solution {
    public string[] solution(string myStr) {
        
        char[] splitChars = {'a', 'b', 'c'};
        
        string[] answer = myStr.Split(splitChars, System.StringSplitOptions.RemoveEmptyEntries);
        string[] emptyArr = {"EMPTY"};
        
        if (answer.Length == 0)
            answer = emptyArr;
        
        return answer;
    }
}