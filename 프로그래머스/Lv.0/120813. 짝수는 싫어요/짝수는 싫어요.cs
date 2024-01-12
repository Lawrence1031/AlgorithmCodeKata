using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        
        List<int> resultList = new List<int>();
        
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                resultList.Add(i);
            }
        }
        
        answer = resultList.ToArray();
        
        return answer;
    }
}