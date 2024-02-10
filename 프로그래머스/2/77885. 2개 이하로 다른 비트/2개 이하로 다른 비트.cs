using System;

public class Solution {
    public long[] solution(long[] numbers) {        
        long[] answer = new long[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            long number = numbers[i];
            if ((number & 1) == 0) // 짝수인 경우
            {
                answer[i] = number + 1;
            }
            else
            {
                long m = number + 1;
                answer[i] = number + (m & -m) / 2;
            }
        }
        
        return answer;
    }
}