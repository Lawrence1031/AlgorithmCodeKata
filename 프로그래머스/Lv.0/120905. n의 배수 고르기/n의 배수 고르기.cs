using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int[] answer = new int[] {};
        
        List<int> result = new List<int> ();
        
        for (int i = 0; i < numlist.Length; i++)
        {
            if (numlist[i] % n == 0)
                result.Add(numlist[i]);
        }
        
        answer = result.ToArray();
        
        return answer;
    }
}