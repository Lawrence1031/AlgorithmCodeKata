using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        
        List<int> numList = new List<int> (num_list);
        
        numList.InsertRange(0, numList);
        numList.RemoveRange(num_list.Length + n, num_list.Length - n);
        numList.RemoveRange(0, n);
        
        answer = numList.ToArray();
        
        
        
        return answer;
    }
}