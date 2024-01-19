using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        int[] answer = new int[] {};
        List<int> result = new List<int> ();
        string tmp = "";
        
        for (int i = 0; i < intStrs.Length; i++)
        {
            int number = 0;
            tmp = intStrs[i].Substring(s, l);
            
            number = Convert.ToInt32(tmp);
            
            if (number > k)
            {
                result.Add(number);
            }
        }
        
        answer = result.ToArray();
        
        return answer;
    }
}