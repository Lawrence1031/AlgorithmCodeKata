using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        Array.Sort(array);
        
        int left = 0;
        int right = array.Length - 1;
        int mid = 0;
        
        while (left <= right)
        {
            mid = left + (right - left) / 2;
            
            if (array[mid] == n)
            {
                answer = array[mid];
                return answer;
            }
            else if (array[mid] < n)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        
        int idx = mid;
        if (mid > 0 && Math.Abs(array[mid - 1] - n) <= Math.Abs(array[mid] - n))
        {
            idx = mid - 1;
        }
        if (mid < array.Length - 1 && Math.Abs(array[mid + 1] - n) < Math.Abs(array[idx] - n))
        {
            idx = mid + 1;
        }
        
        answer = array[idx];
        
        return answer;
    }
}