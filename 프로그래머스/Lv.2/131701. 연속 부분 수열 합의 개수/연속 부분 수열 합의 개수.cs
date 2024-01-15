using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        int answer = 0;
        int len = elements.Length;
        HashSet<int> subsetSums = new HashSet<int>();

        for (int start = 0; start < len; start++)
        {
            int sum = 0;
            for (int length = 1; length <= len; length++)
            {
                sum += elements[(start + length - 1) % len];
                subsetSums.Add(sum);
            }
        }

        answer = subsetSums.Count;
        
        return answer;
    }
}