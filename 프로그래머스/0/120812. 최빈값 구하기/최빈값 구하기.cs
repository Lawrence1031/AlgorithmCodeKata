using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        int answer = -1;
        
        Dictionary<int, int> numberCnt = new Dictionary<int, int>();
        
        foreach (int num in array)
        {
            if (numberCnt.ContainsKey(num))
            {
                numberCnt[num]++;
            }
            else
            {
                numberCnt[num] = 1;
            }
        }
        
        int maxValue = numberCnt.Values.Max();
        int maxValueCnt = numberCnt.Values.Count(value => value == maxValue);
        
        if (maxValueCnt == 1)
        {
            answer = numberCnt.FirstOrDefault(pair => pair.Value == maxValue).Key;
        }        
        
        return answer;
    }
}