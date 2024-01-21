using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[k];
        
        List<int> result = new List<int> ();
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (!result.Contains(arr[i]))
            {
                result.Add(arr[i]);
                
                if (result.Count == k)
                {
                    break;
                }
            }
        }
        
        while (result.Count != k)
        {
            result.Add(-1);
        }
        
        answer = result.ToArray();
        
        return answer;
    }
}