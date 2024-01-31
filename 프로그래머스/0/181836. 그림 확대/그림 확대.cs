using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] picture, int k) {
        string[] answer = new string[] {};
        List<string> picList = new List<string>();
        
        string picStr = "";
        
        foreach (string str in picture)
        {
            foreach (char c in str)
            {
                for (int i = 0; i < k; i++)
                {
                     picStr += c;
                }
                
            }
            
            for (int i = 0; i < k; i++)
            {
                picList.Add(picStr);
            }
            picStr = "";
        }
        
        answer = picList.ToArray();
        
        
        return answer;
    }
}