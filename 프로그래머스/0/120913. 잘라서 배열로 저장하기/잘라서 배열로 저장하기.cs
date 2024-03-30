using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer = new string[] {};
        List<string> result = new List<string>();
        
        for (int i = 0; i < my_str.Length; i += n)
        {
            if (i + n <= my_str.Length)
            {
                result.Add(my_str.Substring(i, n));
            }
            else
            {
                result.Add(my_str.Substring(i));
            }
        }
        
        answer = result.ToArray();
        
        return answer;
    }
}