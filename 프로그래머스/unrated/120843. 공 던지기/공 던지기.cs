using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        
        int result;
        result = (2 * k - 2) % numbers.Length;
        answer = numbers[result];
                         
        return answer;
    }
}