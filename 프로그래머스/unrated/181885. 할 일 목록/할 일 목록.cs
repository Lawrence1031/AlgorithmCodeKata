using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        string[] answer = new string[] {};
        
        answer = todo_list.Where((value, index) => !finished[index]).ToArray();
        
        return answer;
    }
}