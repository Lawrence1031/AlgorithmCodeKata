using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        int[] answer = new int[] {};
        
        List<int> arrList = new List<int> ();
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (flag[i])
            {
                for (int j = 0; j < 2 * arr[i]; j++)
                {
                    arrList.Add(arr[i]);
                }
            }
            else
            {
                for (int j = 0; j < arr[i]; j++)
                {
                    arrList.RemoveAt(arrList.Count - 1);
                }
            }
        }
        
        answer = arrList.ToArray();
        
        return answer;
    }
}