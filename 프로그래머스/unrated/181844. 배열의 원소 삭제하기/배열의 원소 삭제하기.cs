using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        int[] answer = new int[] {};
        
        List<int> arrList = arr.ToList();
        
        foreach (int i in delete_list)
        {
            arrList.Remove(i);
        }
        
        answer = arrList.ToArray();
        
        return answer;
    }
}