using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] names) {
        string[] answer = new string[] {};
        List<string> namesList = new List<string> ();
        
        for (int i = 0; i < names.Length; i = i + 5)
        {
            namesList.Add(names[i]);
        }
        
        answer = namesList.ToArray();
        return answer;
    }
}