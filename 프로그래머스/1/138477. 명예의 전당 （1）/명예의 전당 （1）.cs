using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] result = new int[score.Length];
        List<int> middle = new List<int>();

        for (int i = 0; i < score.Length; i++)
        {
            middle.Add(score[i]);

            if (middle.Count > k)
            {
                middle.Remove(middle.Min());
            }

            result[i] = middle.Min();
        }
        
        
        return result;
    }
}