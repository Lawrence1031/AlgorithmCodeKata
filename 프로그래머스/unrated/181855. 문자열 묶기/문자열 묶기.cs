using System;

public class Solution {
    public int solution(string[] strArr) {
        int answer = 0;
        int tmp = 0;
        int bigNumIdx = 0;
        
        int[] nums = new int[30];
        
        for (int i = 0; i < strArr.Length; i++)
        {
            tmp = strArr[i].Length;
            nums[tmp - 1]++;
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[bigNumIdx])
            {
                bigNumIdx = i;
            }
        }
        
        answer = nums[bigNumIdx];
        
        return answer;
    }
}