using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[] {};
        List<int> tmpList = new List<int> ();
        
        for (int i = n - 1; i < num_list.Length; i++)
        {
            tmpList.Add(num_list[i]);
        }
        
        answer = tmpList.ToArray();
        
        return answer;
    }
}