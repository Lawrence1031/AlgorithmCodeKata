using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        
        List<int> nList = new List<int> ();
        int tmp = n;
        
        // x가 짝수 -> x = x / 2;
        // x가 홀수 -> x = x * 3 + 1;
        
        nList.Add(n);
        
        for (int i = 1; tmp != 1; i++)
        {
            if (tmp % 2 == 0)
            {
                tmp = tmp / 2;
                nList.Add(tmp);
            }
            else
            {
                tmp = 3 * tmp + 1;
                nList.Add(tmp);
            }
        }
        
        answer = nList.ToArray();
        return answer;
    }
}