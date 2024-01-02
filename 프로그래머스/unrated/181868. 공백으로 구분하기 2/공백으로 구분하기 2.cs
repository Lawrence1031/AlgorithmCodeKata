using System;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        
        answer = my_string.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        return answer;
    }
}