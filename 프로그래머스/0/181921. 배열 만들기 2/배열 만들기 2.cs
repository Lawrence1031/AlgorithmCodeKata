using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        int[] answer = new int[] {};
        List<int> result = new List<int> ();
        
        for (int i = l; i <= r; i++)
        {
            string str = i.ToString();
            
            if (str.All(s => s == '0' || s == '5'))
            {
                result.Add(i);
            }
        }
        
        if (!result.Any())
        {
            result.Add(-1);
        }
        
        answer = result.ToArray();
        
        return answer;
    }
}