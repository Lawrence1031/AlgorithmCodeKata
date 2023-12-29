using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k) {
        int[] answer = new int[] {};
        List<int> numList = new List<int> ();
        
        for (int i = 1; i <= n / k; i++)
        {
            numList.Add(i * k);
        }
        
        answer = numList.ToArray();
        return answer;
    }
}