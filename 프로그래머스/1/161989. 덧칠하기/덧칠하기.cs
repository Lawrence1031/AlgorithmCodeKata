using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int len = section.Length;

        for (int i = 0; i < len; i++) 
        {
            int start = section[i];
            int end = start + m - 1;
            int idx = BinarySearch(section, end);
            answer++;
            i = idx - 1;
        }
        
        return answer;
    }
    
    private int BinarySearch(int[] arr, int target) 
    {
        int left = 0, right = arr.Length;

        while (left < right) 
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] <= target)
                left = mid + 1;
            else
                right = mid;
        }

        return left;
    }
}