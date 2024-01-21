using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] stk = new int[] {};
        List<int> stkList = new List<int>();
        
        int i = 0;
        
        while (i != arr.Length)
        {
            if (stkList.Count == 0)
            {
                stkList.Add(arr[i]);
                i++;
            }
            else if (stkList[stkList.Count - 1] < arr[i])
            {
                stkList.Add(arr[i]);
                i++;
            }
            else if (stkList[stkList.Count - 1] >= arr[i])
            {
                stkList.RemoveAt(stkList.Count - 1);
            }
        }
        
        
        stk = stkList.ToArray();
        
        return stk;
    }
}