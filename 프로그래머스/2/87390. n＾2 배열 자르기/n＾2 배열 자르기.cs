using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[] {};
        
        List<int> arrList = new List<int>();

        for (long i = left; i <= right; i++)
        {
            int x = (int)(i % n);
            int y = (int)(i / n);
            int number = (x <= y) ? y : x;

            arrList.Add(number + 1);
        }
        
        answer = arrList.ToArray();
        
        return answer;
    }
}