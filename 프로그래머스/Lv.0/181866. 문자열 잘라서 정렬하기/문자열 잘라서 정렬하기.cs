using System;
using System.Linq;

public class Solution {
    public string[] solution(string myString) {
        string[] answer = myString.Split('x');
        answer = answer.Where(s => !string.IsNullOrEmpty(s)).ToArray();
        Array.Sort(answer);
        
        return answer;
    }
}