using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string[] solution(string[] picture, int k) {
        string[] answer = new string[] {};
        List<string> picList = new List<string>();
        
        foreach (string txt in picture)
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (char c in txt)
            {
                sb.Append(new string(c, k));
            }
            
            string result = sb.ToString();
            
            for (int i = 0; i < k; i++)
            {
                picList.Add(result);
            }
        }
        
        answer = picList.ToArray();
        
        return answer;
    }
}