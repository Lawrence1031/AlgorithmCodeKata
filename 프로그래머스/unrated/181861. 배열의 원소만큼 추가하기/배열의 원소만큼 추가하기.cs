using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> arrList = new List<int> ();
        
        foreach (int num in arr)
        {
            for (int i = 0; i < num; i++)
            {
                arrList.Add(num);
            }
        }
        
        answer = arrList.ToArray();
        
        return answer;
    }
}