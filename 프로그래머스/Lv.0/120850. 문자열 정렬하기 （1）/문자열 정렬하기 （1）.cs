using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[] {};
        
        List<int> answerList = new List<int> ();
        
        foreach(char c in my_string)
        {
            if (char.IsDigit(c))
            {
                answerList.Add(c - '0');
            }
        }
        
        answerList.Sort();
        
        answer = answerList.ToArray();
        return answer;
    }
}