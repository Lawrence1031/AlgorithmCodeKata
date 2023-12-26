using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        
        if (arr1.Length != arr2.Length)
        {
            if (arr1.Length > arr2.Length)
                answer = 1;
            else if (arr1.Length < arr2.Length)
                answer = -1;            
        }
        else
        {
            int tmp1 = 0;
            int tmp2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                tmp1 += arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                tmp2 += arr2[i];
            }

            if (tmp1 > tmp2)
                answer = 1;
            else if (tmp1 == tmp2)
                answer = 0;
            else
                answer = -1;
        }
        
        return answer;
    }
}