using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int maxInt = -1;
        int secInt = -1;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= maxInt)
            {
                secInt = maxInt;
                maxInt = numbers[i];                
            }
            else if (numbers[i] < maxInt && numbers[i] >= secInt)
                secInt = numbers[i];
        }
        
        answer = maxInt * secInt;
                
        return answer;
    }
}