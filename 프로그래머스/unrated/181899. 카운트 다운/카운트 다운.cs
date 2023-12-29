using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start, int end_num) {
        int[] answer = new int[start - end_num];
        
        List<int> numList = new List<int> ();
        
        for (int i = start; i >= end_num; i--)
        {
            numList.Add(i);
        }
        
        answer = numList.ToArray();
        return answer;
    }
}