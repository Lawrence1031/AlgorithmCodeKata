using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_str, int n) {
        string[] answer = new string[] {};
        List<string> result = new List<string>();
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < my_str.Length; i++)
        {
            if (sb.Length == n)
            {
                result.Add(sb.ToString());
                sb.Clear();
                sb.Append(my_str[i]);
            }
            else
            {
                sb.Append(my_str[i]);
            }
        }
        
        if (sb.Capacity != 0)
        {
            result.Add(sb.ToString());
        }
        
        answer = result.ToArray();
        
        return answer;
    }
}