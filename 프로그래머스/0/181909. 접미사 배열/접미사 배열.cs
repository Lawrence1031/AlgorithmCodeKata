using System;
using System.Linq;
using System.Collections.Generic;


public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        
        List<string> result = new List<string> ();
        
        for (int i = 0; i < my_string.Length; i++)
        {
            result.Add(my_string.Substring(i, my_string.Length - i));
        }
        
        answer = result.OrderBy(n => n).ToArray();
        
        return answer;
    }
}