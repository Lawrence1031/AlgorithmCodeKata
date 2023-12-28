using System;

public class Solution {
    public int[] solution(int[] arr, int k) {
        int[] answer = new int[arr.Length];
        
        if (k % 2 == 1)
        {
            for (int i = 0; i < arr.Length; i++)
                answer[i] = k * arr[i];
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
                answer[i] = k + arr[i];
        }
        
        return answer;
    }
}