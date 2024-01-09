using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        
        int firstIdx = Array.IndexOf(arr, 2);
        int lastIdx = Array.LastIndexOf(arr, 2);
        
        List<int> arrList = new List<int> ();
        
        // 처음 2가 나오는 지점과 마지막으로 2가 나오는 지점을 알면 됨.
        // 2가 1개 나오면 [2]를 return, 2개 0개 나오면 [-1]을 return
        
        if (firstIdx == -1)
        {
            arrList.Add(-1);
        }
        else
        {
            for (int i = firstIdx; i <= lastIdx; i++)
            {
                arrList.Add(arr[i]);
            }
        }
        
        answer = arrList.ToArray();
        
        return answer;
    }
}
