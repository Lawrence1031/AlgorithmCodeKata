using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[] {};
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int tmp = 0;
            tmp = arr[queries[i, 0]];
            arr[queries[i, 0]] = arr[queries[i, 1]];
            arr[queries[i, 1]] = tmp;
        }
        
        answer = arr;
        
        
        return answer;
    }
}