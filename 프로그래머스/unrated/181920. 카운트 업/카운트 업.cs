using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        int[] answer = new int[end_num - start_num];
        List<int> numList = new List<int> ();
        
        for (int i = start_num; i <= end_num; i++)
        {
            numList.Add(i);
        }
        
        answer = numList.ToArray();
        
        
        return answer;
    }
}