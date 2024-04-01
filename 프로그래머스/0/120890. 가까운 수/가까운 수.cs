using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        int closestNum = array[0];
        int diff = Math.Abs(n - array[0]);
        
        foreach (int num in array)
        {
            int curDiff = Math.Abs(n - num);
            
            if (curDiff < diff || (curDiff == diff && num < closestNum))
            {
                closestNum = num;
                diff = curDiff;
            }
        }
        
        answer = closestNum;
        
        return answer;
    }
}
